using System;
using System.Windows.Forms;

namespace Ucaksavar
{
    internal class Ucak : Cisim
    {
        public Ucak()
        {
            Image = System.Drawing.Image.FromFile(@"ucak.png");
            HareketMesafesi = Convert.ToInt32(Math.Round(Image.Height * .1)); // Kendi yüksekliğinin onda biri
            SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
