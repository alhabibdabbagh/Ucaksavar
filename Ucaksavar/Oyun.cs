using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ucaksavar
{
    internal class Oyun : IDisposable
    {
        private Timer _oyunTimer;
        private Timer _hareketTimer;

        private readonly Panel _oyunPaneli;
        private Ucaksavar _ucakSavar;

        private List<Mermi> _mermiListesi; 
        private List<Ucak> _ucakListesi;

        private Random _random;

        public bool OynaniyorMu => _oyunTimer != null && _oyunTimer.Enabled;

        public Oyun(Panel oyunPaneli)
        {
            _oyunPaneli = oyunPaneli;
        }

        public void Dispose()
        {
            _oyunTimer?.Dispose();
        }

        public void Baslat()
        {
            if (_oyunTimer != null) throw new Exception("Zaten başlatılmış olan oyun yeniden başlatılmak isteniyor.");

            _oyunPaneli.Controls.Clear();

            _mermiListesi = new List<Mermi>();
            _ucakListesi = new List<Ucak>();
            _random = new Random();

            UcaksavarYerlestir();
            ZamanlayicilariOlusturBaslat();
        }

        private void UcaksavarYerlestir()
        {
            _ucakSavar = new Ucaksavar();
            _ucakSavar.Left = Convert.ToInt32(Math.Round((_oyunPaneli.Width - _ucakSavar.Width)/2.0));
            _ucakSavar.Top = _oyunPaneli.Height - _ucakSavar.Height;
            _ucakSavar.HareketAlaniGenislik = _oyunPaneli.Width;
            _ucakSavar.HareketAlaniYukseklik = _oyunPaneli.Height;
            _oyunPaneli.Controls.Add(_ucakSavar);
        }

        public void Bitir()
        {
            ZamanlayicilariDurdurSil();
            _mermiListesi = null;
            _ucakListesi = null;
        }

        private void ZamanlayicilariDurdurSil()
        {
            if (_oyunTimer == null || _hareketTimer == null)
            {
                throw new Exception("Henüz başlatılmamış olan oyun durdurulmak isteniyor.");
            }

            _oyunTimer.Stop();
            _oyunTimer.Dispose();
            
            _hareketTimer.Stop();
            _hareketTimer.Dispose();
        }

        private void ZamanlayicilariOlusturBaslat()
        {
            _oyunTimer = new Timer { Interval = 2000 };
            _oyunTimer.Tick += OyunTimerTick;
            _oyunTimer.Start();

            _hareketTimer = new Timer { Interval = 100 };
            _hareketTimer.Tick += HareketTimerTick;
            _hareketTimer.Start();

            YeniUcakOlustur();
        }

        private void OyunTimerTick(object sender, EventArgs e)
        {
            YeniUcakOlustur();
        }

        private void VurulanUcaklariCikar()
        {
            for (var i = _ucakListesi.Count - 1; i >= 0; i--)
            {
                var ucak = _ucakListesi[i];
                for (var j = _mermiListesi.Count - 1; j >= 0; j--)
                {
                    var mermi = _mermiListesi[j];

                    if (ucak.Bottom < mermi.Top) continue;
                    if (ucak.Left > mermi.Right) continue;
                    if (ucak.Right < mermi.Left) continue;

                    _ucakListesi.RemoveAt(i);
                    _mermiListesi.RemoveAt(j);
                    _oyunPaneli.Controls.Remove(ucak);
                    _oyunPaneli.Controls.Remove(mermi);
                }
            }
        }

        private void YeniUcakOlustur()
        {
            var ucak = new Ucak();
            ucak.Left = ucak.Width * _random.Next(0, Convert.ToInt32(Math.Round(Convert.ToDouble(_oyunPaneli.Width) / ucak.Width)));
            ucak.Top = 0;
            ucak.HareketAlaniGenislik = _oyunPaneli.Width;
            ucak.HareketAlaniYukseklik = _oyunPaneli.Height;

            _ucakListesi.Add(ucak);
            _oyunPaneli.Controls.Add(ucak);
        }

        private void HareketTimerTick(object sender, EventArgs e)
        {
            // Tüm mermiler kontrol ediliyor
            for (var i = _mermiListesi.Count - 1; i >= 0; i--)
            {
                var mermi = _mermiListesi[i];

                var oyunAlaniDisinaCiktiMi = mermi.HareketEttir(Yon.Yukari);
                if (!oyunAlaniDisinaCiktiMi) continue;

                _mermiListesi.RemoveAt(i);
                _oyunPaneli.Controls.Remove(mermi);
            }

            // Tüm uçaklar kontrol ediliyor
            for (var i = _ucakListesi.Count - 1; i >= 0; i--)
            {
                var ucak = _ucakListesi[i];
                var oyunAlaniDisinaCiktiMi = ucak.HareketEttir(Yon.Asagi);
                if (!oyunAlaniDisinaCiktiMi) continue;

                Bitir();
                return;
            }

            VurulanUcaklariCikar();
        }

        public void AtesEt()
        {
            YeniMermiOlustur();
        }

        private void YeniMermiOlustur()
        {
            var mermi = new Mermi();
            mermi.Left = _ucakSavar.Left + Convert.ToInt32(Math.Round((_ucakSavar.Width - mermi.Width) / 2.0));
            mermi.Top = _oyunPaneli.Height - _ucakSavar.Height - mermi.Height;
            mermi.HareketAlaniGenislik = _oyunPaneli.Width;
            mermi.HareketAlaniYukseklik = _oyunPaneli.Height;

            _mermiListesi.Add(mermi);
            _oyunPaneli.Controls.Add(mermi);
        }

        public void UcaksavariHareketEttir(Yon yon)
        {
            _ucakSavar.HareketEttir(yon);
        }
    }
}
