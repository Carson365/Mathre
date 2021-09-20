using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Mathre
{
    public class CustomGroupBox : GroupBox
    {
        public Color BorderColor
        {
            get
            {
                return ColorTranslator.FromWin32(Conversions.ToInteger(FrmMathre.SystemColor));
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