using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace projetogitaula
{
    internal class pictureboxredondo : PictureBox
    {
        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            GraphicsPath caminho = new GraphicsPath();
            caminho.AddEllipse(0, 0, Width - 1, Height - 1);
            Region = new Region(caminho);
        }
    }
}
