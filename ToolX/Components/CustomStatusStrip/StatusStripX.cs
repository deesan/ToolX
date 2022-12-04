using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace ToolX.Components.CustomStatusStrip
{
    public partial class StatusStripX : StatusStrip
    {
        #region Constructor
        public StatusStripX()
        {
            InitializeComponent();

            this.RenderMode = ToolStripRenderMode.Professional;
            this.Renderer = new ToolStripProfessionalRenderer(new CustomStatusStripColorTable());
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the ForeColor of the System.Windows.Forms.StatusStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("StatusStripForeColor")]
        public Color StatusStripForeColor
        {
            get { return Properties.Settings.Default.StatusStripForeColor; }
            set
            {
                Properties.Settings.Default.StatusStripForeColor = value;
                this.ForeColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the starting color of the gradient used on the System.Windows.Forms.StatusStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("StatusStripGradientBegin")]
        public Color StatusStripGradientBegin
        {
            get { return Properties.Settings.Default.StatusStripGradientBegin; }
            set { Properties.Settings.Default.StatusStripGradientBegin = value; }
        }

        /// <summary>
        /// Gets or sets the ending color of the gradient used on the System.Windows.Forms.StatusStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("StatusStripGradientEnd")]
        public Color StatusStripGradientEnd
        {
            get { return Properties.Settings.Default.StatusStripGradientEnd; }
            set { Properties.Settings.Default.StatusStripGradientEnd = value; }
        }
        #endregion

    }
}
