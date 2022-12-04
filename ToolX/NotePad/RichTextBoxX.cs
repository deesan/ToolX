using System;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

namespace ToolX.Components
{
    public class RichTextBoxX : RichTextBox
    {
        public RichTextBoxX()
        {

        }

        private Color linehighlightColor = Color.FromArgb(80, 80, 80);

        protected override void OnSelectionChanged(EventArgs e)
        {
            base.OnSelectionChanged(e);
            this.Invalidate();
        }

        int lineh = 15;
        const int wm_paint = 15;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == wm_paint)
            {
                var selectlength = this.SelectionLength;
                var selectstart = this.SelectionStart;
                this.Invalidate();
                base.WndProc(ref m);
                if (selectlength > 0)
                {
                    return;
                }
                using (Graphics g = Graphics.FromHwnd(this.Handle))
                {
                    Brush b = new SolidBrush(Color.FromArgb(50, linehighlightColor));
                    int fntsize = (int)this.Font.Size;
                    var line = this.GetLineFromCharIndex(selectstart);
                    var loc = this.GetPositionFromCharIndex(this.GetFirstCharIndexFromLine(line));
                    g.FillRectangle(b, new Rectangle(loc, new Size(this.Width, lineh + fntsize - 3)));
                }
            }
            else
            {
                base.WndProc(ref m);
            }
        }
    }
}
