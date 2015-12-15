using System.Drawing;
using System.Windows.Forms;

namespace jimney
{
    class OverlayControl : Control
    {
        public Image Image
        {
            get;
            set;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;
                return cp;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // base.OnPaintBackground(pevent);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Image != null)
            {
                e.Graphics.DrawImage(Image, ClientRectangle);
            }
        }
    }
}
