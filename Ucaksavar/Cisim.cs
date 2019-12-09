using System;
using System.Windows.Forms;

namespace Ucaksavar
{
    internal abstract class Cisim : PictureBox, ICisim
    {
        public int HareketMesafesi { get; set; }
        public int HareketAlaniGenislik { get; set; }
        public int HareketAlaniYukseklik { get; set; }

        public bool HareketEttir(Yon yon)
        {
            switch (yon)
            {
                case Yon.Sag:
                    if (Right + HareketMesafesi > HareketAlaniGenislik)
                    {
                        Left = HareketAlaniGenislik - Width;
                        return true;
                    }
                    Left += HareketMesafesi;
                    break;
                 case Yon.Sol:
                    if (Left - HareketMesafesi < 0)
                    {
                        Left = 0;
                        return true;
                    }
                    Left -= HareketMesafesi;
                    break;
               case Yon.Asagi:
                    if (Bottom + HareketMesafesi > HareketAlaniYukseklik)
                    {
                        Top = HareketAlaniYukseklik - Height;
                        return true;
                    }
                    Top += HareketMesafesi;
                    break;
                case Yon.Yukari:
                    if (Top - HareketMesafesi < 0)
                    {
                        Top = 0;
                        return true;
                    }
                    Top -= HareketMesafesi;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return false;
        }
    }
}
