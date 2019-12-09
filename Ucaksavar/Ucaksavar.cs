using System.Windows.Forms;

namespace Ucaksavar
{
    internal class Ucaksavar : Cisim
    {
        public Ucaksavar()
        {
            Image = System.Drawing.Image.FromFile(@"ucaksavar.png");
            HareketMesafesi = Image.Width; // Kendi genişliği kadar
            SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
