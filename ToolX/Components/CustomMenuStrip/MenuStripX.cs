using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace ToolX.Components.CustomMenuStrip
{
    public partial class MenuStripX : MenuStrip
    {
        #region Constructor
        public MenuStripX()
        {
           this.Renderer = new  MyMenuRenderer();
        }
        #endregion

        #region Properties
        [Category("Style")]
        [DisplayName("MenuStripForeColor")]
        public Color MenuStripForeColor
        {
            get { return Properties.Settings.Default.MenuStripForeColor; }
            set
            {
                Properties.Settings.Default.MenuStripForeColor = value;
                this.ForeColor = value;
            }
        }

        [Category("Style")]
        [DisplayName("MenuStripGradientBegin")]
        public Color MenuStripGradientBegin
        {
            get { return Properties.Settings.Default.MenuStripGradientBegin; }
            set { Properties.Settings.Default.MenuStripGradientBegin = value; }
        }

        [Category("Style")]
        [DisplayName("MenuStripGradientEnd")]
        public Color MenuStripGradientEnd
        {
            get { return Properties.Settings.Default.MenuStripGradientEnd; }
            set { Properties.Settings.Default.MenuStripGradientEnd = value; }
        }

        [Category("Style")]
        [DisplayName("MenuBorder")]
        public Color MenuBorder
        {
            get { return Properties.Settings.Default.MenuBorder; }
            set { Properties.Settings.Default.MenuBorder = value; }
        }
        #endregion
    }

    public class  MyMenuRenderer : ToolStripRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {

            Brush b1 = new LinearGradientBrush(e.Item.ContentRectangle,  Properties.Settings.Default.MenuStripGradientBegin, Properties.Settings.Default.MenuStripGradientEnd, 90);

            base.OnRenderMenuItemBackground(e);

            if (e.Item.Enabled)
            {
                if (e.Item.IsOnDropDown == false && e.Item.Selected)
                {
                    var rect1 = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
                    var rect2 = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
                    e.Graphics.FillRectangle(b1, rect1);
                    e.Graphics.DrawRectangle(new Pen(b1), rect2);
                    e.Item.ForeColor = Properties.Settings.Default.MenuStripForeColor;
                }
                else
                {
                    e.Item.ForeColor = Properties.Settings.Default.MenuStripForeColor;
                }

                if (e.Item.IsOnDropDown && e.Item.Selected)
                {
                    var rect = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
                    e.Graphics.FillRectangle(b1, rect);
                    e.Graphics.DrawRectangle(new Pen(b1), rect);
                    e.Item.ForeColor = Color.White;
                }

                if ((e.Item as ToolStripMenuItem).DropDown.Visible && e.Item.IsOnDropDown == false)
                {
                    var rect = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
                    var rect2 = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
                    e.Graphics.FillRectangle(b1, rect);
                    e.Graphics.DrawRectangle(new Pen(b1), rect2);
                    e.Item.ForeColor = Properties.Settings.Default.MenuStripForeColor;
                }
            }
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            base.OnRenderSeparator(e);
            var DarkLine = new SolidBrush(Color.FromArgb(30, 30, 30));
            var rect = new Rectangle(30, 3, e.Item.Width - 1, 1);
            e.Graphics.FillRectangle(DarkLine, rect);
        }

        protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
        {
            base.OnRenderItemCheck(e);

            if (e.Item.Selected)
            {
                var rect = new Rectangle(4, 2, 18, 18);
                var rect2 = new Rectangle(5, 3, 16, 16);
                SolidBrush b = new SolidBrush(Color.FromArgb(0, 34, 33));
                SolidBrush b2 = new SolidBrush(Color.FromArgb(220, 220, 220));

                e.Graphics.FillRectangle(b, rect);
                e.Graphics.FillRectangle(b2, rect2);
                e.Graphics.DrawImage(e.Image, new Point(5, 3));
            }
            else
            {
                var rect = new Rectangle(4, 2, 18, 18);
                var rect2 = new Rectangle(5, 3, 16, 16);
                SolidBrush b = new SolidBrush(Color.White);
                SolidBrush b2 = new SolidBrush(Color.FromArgb(255, 80, 90, 90));

                e.Graphics.FillRectangle(b, rect);
                e.Graphics.FillRectangle(b2, rect2);
                e.Graphics.DrawImage(e.Image, new Point(5, 3));
            }
        }

        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        {
            base.OnRenderImageMargin(e);

            var rect = new Rectangle(0, 0, e.ToolStrip.Width, e.ToolStrip.Height);
            Brush b1 = new LinearGradientBrush(rect, Properties.Settings.Default.MenuStripGradientBegin, Properties.Settings.Default.MenuStripGradientEnd, 90);
            e.Graphics.FillRectangle(b1, rect);

            var DarkLine = b1;
            var rect3 = new Rectangle(0, 0, 26, e.AffectedBounds.Height);
            e.Graphics.FillRectangle(DarkLine, rect3);

            e.Graphics.DrawLine(new Pen(b1), 28, 0, 28, e.AffectedBounds.Height);

            var rect2 = new Rectangle(0, 0, e.ToolStrip.Width - 1, e.ToolStrip.Height - 1);
            e.Graphics.DrawRectangle(new Pen(b1), rect2);
        }
    }
}
