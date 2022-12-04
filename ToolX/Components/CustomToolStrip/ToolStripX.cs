using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace ToolX.Components.CustomToolStrip
{
    public partial class ToolStripX : ToolStrip
    {
        #region Constructor
        public ToolStripX()
        {

            //this.Renderer = new MyToolStripRenderer();

            InitializeComponent();

            this.RenderMode = ToolStripRenderMode.Professional;
            this.Renderer = new ToolStripProfessionalRenderer(new CustomToolStrip.CustomToolStripColorTable());
        }
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the ForeColor of the System.Windows.Forms.ToolStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("ToolStripForeColor")]
        public Color ToolStripForeColor
        {
            get { return Properties.Settings.Default.ToolStripForeColor; }
            set
            {
                Properties.Settings.Default.ToolStripForeColor = value;
                this.ForeColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the border color of the System.Windows.Forms.ToolStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("ToolStripBorder")]
        public Color ToolStripBorder
        {
            get { return Properties.Settings.Default.ToolStripBorder; }
            set { Properties.Settings.Default.ToolStripBorder = value; }
        }

        /// <summary>
        /// Gets or sets the starting color of the content panel gradient on System.Windows.Forms.ToolStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("ToolStripContentPanelGradientBegin")]
        public Color ToolStripContentPanelGradientBegin
        {
            get { return Properties.Settings.Default.ToolStripContentPanelGradientBegin; }
            set { Properties.Settings.Default.ToolStripContentPanelGradientBegin = value; }
        }

        /// <summary>
        /// Gets or sets the ending color of the content panel gradient on System.Windows.Forms.ToolStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("ToolStripContentPanelGradientEnd")]
        public Color ToolStripContentPanelGradientEnd
        {
            get { return Properties.Settings.Default.ToolStripContentPanelGradientEnd; }
            set { Properties.Settings.Default.ToolStripContentPanelGradientEnd = value; }
        }

        /// <summary>
        /// Gets or sets the background color of the drop down on the System.Windows.Forms.ToolStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("ToolStripDropDownBackground")]
        public Color ToolStripDropDownBackground
        {
            get { return Properties.Settings.Default.ToolStripDropDownBackground; }
            set { Properties.Settings.Default.ToolStripDropDownBackground = value; }
        }

        /// <summary>
        /// Gets or sets the starting color of the gradient on the System.Windows.Forms.ToolStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("ToolStripGradientBegin")]
        public Color ToolStripGradientBegin
        {
            get { return Properties.Settings.Default.ToolStripGradientBegin; }
            set { Properties.Settings.Default.ToolStripGradientBegin = value; }
        }

        /// <summary>
        /// Gets or sets the middle color of the gradient on the System.Windows.Forms.ToolStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("ToolStripGradientMiddle")]
        public Color ToolStripGradientMiddle
        {
            get { return Properties.Settings.Default.ToolStripGradientMiddle; }
            set { Properties.Settings.Default.ToolStripGradientMiddle = value; }
        }

        /// <summary>
        /// Gets or sets the ending color of the gradient on the System.Windows.Forms.ToolStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("ToolStripGradientEnd")]
        public Color ToolStripGradientEnd
        {
            get { return Properties.Settings.Default.ToolStripGradientEnd; }
            set { Properties.Settings.Default.ToolStripGradientEnd = value; }
        }
        #endregion
    }

    //public class MyToolStripRenderer : ToolStripProfessionalRenderer
    //{
    //    protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
    //    {
    //        base.OnRenderButtonBackground(e);
    //        var rectBorder = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
    //        var rect = new Rectangle(1, 1, e.Item.Width - 2, e.Item.Height - 2);
    //        Brush b2 = new System.Drawing.Drawing2D.LinearGradientBrush(e.Item.ContentRectangle, Color.FromArgb(0, 34, 33), Color.FromArgb(1, 58, 67), 90);
    //        Brush b4 = new System.Drawing.Drawing2D.LinearGradientBrush(e.Item.ContentRectangle, Color.FromArgb(0, 34, 33), Color.FromArgb(0, 34, 33), 90);

    //        if (e.Item.Selected == true || (e.Item as ToolStripButton).Checked)
    //        {
    //            e.Graphics.FillRectangle(b2, rect);
    //            e.Graphics.DrawRectangle(new Pen(b2), rectBorder);
    //            e.Item.ForeColor = Color.Black;
    //        }
    //        else
    //        {
    //            e.Graphics.DrawRectangle(new Pen(b2), rectBorder);
    //            e.Graphics.FillRectangle(b4, rect);
    //        }

    //        if (e.Item.Pressed)
    //        {
    //            using (var b = new LinearGradientBrush(rect, Color.FromArgb(0, 34, 33), Color.FromArgb(1, 58, 67), 90))
    //            {
    //                using (var b3 = b)
    //                {
    //                    e.Graphics.FillRectangle(b3, rectBorder);
    //                    e.Graphics.FillRectangle(b, rect);
    //                }
    //            }
    //        }
    //    }
    //}
}
