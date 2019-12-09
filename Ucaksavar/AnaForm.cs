using System.Windows.Forms;

namespace Ucaksavar
{
    public partial class AnaForm : Form
    {
        private Oyun _oyun;

        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    EnterTusunaBasildi();
                    break;
                case Keys.Space:
                    BoslukTusunaBasildi();
                    break;
                case Keys.Up:
                case Keys.NumPad8:
                    YonTusunaBasildi(Yon.Yukari);
                    break;
                case Keys.Right:
                case Keys.NumPad6:
                    YonTusunaBasildi(Yon.Sag);
                    break;
                case Keys.Down:
                case Keys.NumPad2:
                    YonTusunaBasildi(Yon.Asagi);
                    break;
                case Keys.Left:
                case Keys.NumPad4:
                    YonTusunaBasildi(Yon.Sol);
                    break;
            }
        }

        private void BoslukTusunaBasildi()
        {
            if (!OyunOynaniyorMu()) return;

            _oyun.AtesEt();
        }

        private void YonTusunaBasildi(Yon yon)
        {
            if (!OyunOynaniyorMu()) return;
            if (yon == Yon.Asagi || yon == Yon.Yukari) return;

            _oyun.UcaksavariHareketEttir(yon);
        }

        private void EnterTusunaBasildi()
        {
            if (OyunOynaniyorMu()) return;

            _oyun = new Oyun(oyunPaneli);
            _oyun.Baslat();
        }

        private bool OyunOynaniyorMu()
        {
            return _oyun != null && _oyun.OynaniyorMu;
        }

        private void AnaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _oyun?.Dispose();
        }
    }
}
