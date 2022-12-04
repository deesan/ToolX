using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace ToolX.Components
{
    public partial class ContextMenuStripX : ContextMenuStrip
    {
        #region Constructor
        public ContextMenuStripX()
        {
            this.Renderer = new CustomMenuStrip.MyMenuRenderer();
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
}
