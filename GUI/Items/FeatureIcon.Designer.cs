namespace MiniStore.GUI
{
    partial class FeatureIcon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gPanel1 = new MiniStore.Costumized.GPanel();
            this.FeaturePic = new FontAwesome.Sharp.IconPictureBox();
            this.FeatureName = new System.Windows.Forms.Label();
            this.gPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeaturePic)).BeginInit();
            this.SuspendLayout();
            // 
            // gPanel1
            // 
            this.gPanel1.BackColor = System.Drawing.Color.White;
            this.gPanel1.BorderRadius = 30;
            this.gPanel1.Controls.Add(this.FeaturePic);
            this.gPanel1.Controls.Add(this.FeatureName);
            this.gPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gPanel1.ForeColor = System.Drawing.Color.Black;
            this.gPanel1.GradientAngle = 90F;
            this.gPanel1.GradientBottomColor = System.Drawing.Color.MediumPurple;
            this.gPanel1.GradientTopColor = System.Drawing.Color.Purple;
            this.gPanel1.Location = new System.Drawing.Point(0, 0);
            this.gPanel1.Name = "gPanel1";
            this.gPanel1.Size = new System.Drawing.Size(300, 400);
            this.gPanel1.TabIndex = 0;
            // 
            // FeaturePic
            // 
            this.FeaturePic.BackColor = System.Drawing.Color.Transparent;
            this.FeaturePic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FeaturePic.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            this.FeaturePic.IconColor = System.Drawing.Color.White;
            this.FeaturePic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FeaturePic.IconSize = 300;
            this.FeaturePic.Location = new System.Drawing.Point(0, 0);
            this.FeaturePic.Name = "FeaturePic";
            this.FeaturePic.Size = new System.Drawing.Size(300, 317);
            this.FeaturePic.TabIndex = 1;
            this.FeaturePic.TabStop = false;
            this.FeaturePic.Click += new System.EventHandler(this.FeaturePic_Click);
            this.FeaturePic.MouseEnter += new System.EventHandler(this.FeaturePic_MouseEnter);
            this.FeaturePic.MouseLeave += new System.EventHandler(this.FeaturePic_MouseLeave);
            // 
            // FeatureName
            // 
            this.FeatureName.BackColor = System.Drawing.Color.Transparent;
            this.FeatureName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FeatureName.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeatureName.ForeColor = System.Drawing.Color.White;
            this.FeatureName.Location = new System.Drawing.Point(0, 317);
            this.FeatureName.Name = "FeatureName";
            this.FeatureName.Size = new System.Drawing.Size(300, 83);
            this.FeatureName.TabIndex = 0;
            this.FeatureName.Text = "FeatureName";
            this.FeatureName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FeatureName.Click += new System.EventHandler(this.FeatureName_Click);
            this.FeatureName.MouseEnter += new System.EventHandler(this.FeatureName_MouseEnter);
            this.FeatureName.MouseLeave += new System.EventHandler(this.FeatureName_MouseLeave);
            // 
            // FeatureIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gPanel1);
            this.Name = "FeatureIcon";
            this.Size = new System.Drawing.Size(300, 400);
            this.gPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FeaturePic)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private MiniStore.Costumized.GPanel gPanel1;
        private System.Windows.Forms.Label FeatureName;
        private FontAwesome.Sharp.IconPictureBox FeaturePic;
    }
}
