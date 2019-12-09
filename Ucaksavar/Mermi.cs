using System;
using System.Windows.Forms;

namespace Ucaksavar
{
    internal class Mermi : Cisim
    {
        public Mermi()
        {
            Image = System.Drawing.Image.FromFile(@"mermi.png");
            HareketMesafesi = Convert.ToInt32(Math.Round(Image.Height * 1.5)); // Kendi yüksekliğinin 1,5 katı
            SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
