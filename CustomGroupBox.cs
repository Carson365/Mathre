using Microsoft.VisualBasic.CompilerServices;
using System.Drawing;
using System.Windows.Forms;

namespace Mathre
{
    public class CustomGroupBox : GroupBox
    {
        public Color BorderColor
        {
            get
            {
                return FrmMathre.SystemColor;
            }

            set
            {
                Invalidate();
                if (DesignMode)
                    Parent?.Invalidate(Bounds);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var rect = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);
            ControlPaint.DrawBorder(e.Graphics, rect, BorderColor, ButtonBorderStyle.Solid);
            rect.Inflate(-1, -1);
            ControlPaint.DrawBorder(e.Graphics, rect, BorderColor, ButtonBorderStyle.Solid);
        }
    }
}