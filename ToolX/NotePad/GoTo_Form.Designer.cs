namespace ToolX.NotePad
{
    partial class GoTo_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoTo_Form));
            this.MainElips = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.BasePanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.HeaderPaenl = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblFormName = new Guna.UI.WinForms.GunaLabel();
            this.ClosePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.GoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.txtGoLine = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLocal1 = new Guna.UI.WinForms.GunaLabel();
            this.HeaderPanelDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.formNameDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.BasePanel.SuspendLayout();
            this.HeaderPaenl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).BeginInit();
            this.SuspendLayout();
            // 
            // MainElips
            // 
            this.MainElips.BorderRadius = 2;
            this.MainElips.TargetControl = this;
            // 
            // BasePanel
            // 
            this.BasePanel.BackColor = System.Drawing.Color.Transparent;
            this.BasePanel.BorderColor = System.Drawing.Color.White;
            this.BasePanel.BorderRadius = 2;
            this.BasePanel.BorderThickness = 2;
            this.BasePanel.Controls.Add(this.HeaderPaenl);
            this.BasePanel.Controls.Add(this.GoBtn);
            this.BasePanel.Controls.Add(this.txtGoLine);
            this.BasePanel.Controls.Add(this.lblLocal1);
            this.BasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.BasePanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(67)))));
            this.BasePanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.BasePanel.Location = new System.Drawing.Point(0, 0);
            this.BasePanel.Name = "BasePanel";
            this.BasePanel.ShadowDecoration.Parent = this.BasePanel;
            this.BasePanel.Size = new System.Drawing.Size(277, 137);
            this.BasePanel.TabIndex = 1;
            // 
            // HeaderPaenl
            // 
            this.HeaderPaenl.BorderColor = System.Drawing.Color.White;
            this.HeaderPaenl.BorderRadius = 2;
            this.HeaderPaenl.BorderThickness = 1;
            this.HeaderPaenl.Controls.Add(this.lblFormName);
            this.HeaderPaenl.Controls.Add(this.ClosePic);
            this.HeaderPaenl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.HeaderPaenl.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(67)))));
            this.HeaderPaenl.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.HeaderPaenl.Location = new System.Drawing.Point(2, 2);
            this.HeaderPaenl.Name = "HeaderPaenl";
            this.HeaderPaenl.ShadowDecoration.Parent = this.HeaderPaenl;
            this.HeaderPaenl.Size = new System.Drawing.Size(273, 30);
            this.HeaderPaenl.TabIndex = 12;
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.BackColor = System.Drawing.Color.Transparent;
            this.lblFormName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormName.ForeColor = System.Drawing.Color.White;
            this.lblFormName.Location = new System.Drawing.Point(5, 4);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(49, 21);
            this.lblFormName.TabIndex = 1;
            this.lblFormName.Text = "GoTo";
            this.lblFormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClosePic
            // 
            this.ClosePic.BackColor = System.Drawing.Color.Transparent;
            this.ClosePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClosePic.Image = ((System.Drawing.Image)(resources.GetObject("ClosePic.Image")));
            this.ClosePic.Location = new System.Drawing.Point(245, 2);
            this.ClosePic.Name = "ClosePic";
            this.ClosePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ClosePic.ShadowDecoration.Parent = this.ClosePic;
            this.ClosePic.Size = new System.Drawing.Size(26, 26);
            this.ClosePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosePic.TabIndex = 0;
            this.ClosePic.TabStop = false;
            this.ClosePic.UseTransparentBackground = true;
            this.ClosePic.Click += new System.EventHandler(this.ClosePic_Click);
            // 
            // GoBtn
            // 
            this.GoBtn.Animated = true;
            this.GoBtn.BackColor = System.Drawing.Color.Transparent;
            this.GoBtn.BorderColor = System.Drawing.Color.White;
            this.GoBtn.BorderRadius = 1;
            this.GoBtn.BorderThickness = 1;
            this.GoBtn.CheckedState.Parent = this.GoBtn;
            this.GoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoBtn.CustomImages.Parent = this.GoBtn;
            this.GoBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GoBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.GoBtn.ForeColor = System.Drawing.Color.Black;
            this.GoBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.GoBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.GoBtn.HoverState.Parent = this.GoBtn;
            this.GoBtn.Location = new System.Drawing.Point(86, 98);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.ShadowDecoration.Parent = this.GoBtn;
            this.GoBtn.Size = new System.Drawing.Size(100, 26);
            this.GoBtn.TabIndex = 15;
            this.GoBtn.Text = "Go";
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // txtGoLine
            // 
            this.txtGoLine.Animated = true;
            this.txtGoLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.txtGoLine.BorderRadius = 2;
            this.txtGoLine.BorderThickness = 2;
            this.txtGoLine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGoLine.DefaultText = "";
            this.txtGoLine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGoLine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGoLine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGoLine.DisabledState.Parent = this.txtGoLine;
            this.txtGoLine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGoLine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtGoLine.FocusedState.BorderColor = System.Drawing.Color.Lime;
            this.txtGoLine.FocusedState.Parent = this.txtGoLine;
            this.txtGoLine.ForeColor = System.Drawing.Color.White;
            this.txtGoLine.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGoLine.HoverState.Parent = this.txtGoLine;
            this.txtGoLine.Location = new System.Drawing.Point(15, 66);
            this.txtGoLine.Name = "txtGoLine";
            this.txtGoLine.PasswordChar = '\0';
            this.txtGoLine.PlaceholderText = "";
            this.txtGoLine.SelectedText = "";
            this.txtGoLine.ShadowDecoration.Parent = this.txtGoLine;
            this.txtGoLine.Size = new System.Drawing.Size(249, 22);
            this.txtGoLine.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtGoLine.TabIndex = 14;
            this.txtGoLine.TextChanged += new System.EventHandler(this.txtGoLine_TextChanged);
            // 
            // lblLocal1
            // 
            this.lblLocal1.AutoSize = true;
            this.lblLocal1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal1.ForeColor = System.Drawing.Color.White;
            this.lblLocal1.Location = new System.Drawing.Point(11, 40);
            this.lblLocal1.Name = "lblLocal1";
            this.lblLocal1.Size = new System.Drawing.Size(94, 20);
            this.lblLocal1.TabIndex = 13;
            this.lblLocal1.Text = "Line Number";
            // 
            // HeaderPanelDrag
            // 
            this.HeaderPanelDrag.TargetControl = this.HeaderPaenl;
            // 
            // formNameDrag
            // 
            this.formNameDrag.TargetControl = this.lblFormName;
            // 
            // GoTo_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 137);
            this.Controls.Add(this.BasePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GoTo_Form";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoTo";
            this.Load += new System.EventHandler(this.GoTo_Form_Load);
            this.BasePanel.ResumeLayout(false);
            this.BasePanel.PerformLayout();
            this.HeaderPaenl.ResumeLayout(false);
            this.HeaderPaenl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse MainElips;
        private Guna.UI2.WinForms.Guna2GradientPanel BasePanel;
        private Guna.UI2.WinForms.Guna2GradientPanel HeaderPaenl;
        private Guna.UI.WinForms.GunaLabel lblFormName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ClosePic;
        private Guna.UI2.WinForms.Guna2Button GoBtn;
        private Guna.UI2.WinForms.Guna2TextBox txtGoLine;
        private Guna.UI.WinForms.GunaLabel lblLocal1;
        private Guna.UI2.WinForms.Guna2DragControl HeaderPanelDrag;
        private Guna.UI2.WinForms.Guna2DragControl formNameDrag;
    }
}