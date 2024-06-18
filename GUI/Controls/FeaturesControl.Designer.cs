using MiniStore.Costumized;

namespace MiniStore.GUI
{
    partial class FeaturesControl
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
            this.UserPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NameSpaceLabel = new System.Windows.Forms.Label();
            this.UserN_label = new System.Windows.Forms.Label();
            this.LeftLabel = new System.Windows.Forms.Label();
            this.FlowFeatures = new System.Windows.Forms.FlowLayoutPanel();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.RightLabel = new System.Windows.Forms.Label();
            this.Avatar = new MiniStore.Costumized.Avatar();
            this.UserPanel.SuspendLayout();
            this.FlowFeatures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = System.Drawing.Color.Transparent;
            this.UserPanel.Controls.Add(this.NameSpaceLabel);
            this.UserPanel.Controls.Add(this.Avatar);
            this.UserPanel.Controls.Add(this.UserN_label);
            this.UserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserPanel.Location = new System.Drawing.Point(0, 0);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(1144, 93);
            this.UserPanel.TabIndex = 0;
            // 
            // NameSpaceLabel
            // 
            this.NameSpaceLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameSpaceLabel.Location = new System.Drawing.Point(3, 0);
            this.NameSpaceLabel.Name = "NameSpaceLabel";
            this.NameSpaceLabel.Size = new System.Drawing.Size(121, 23);
            this.NameSpaceLabel.TabIndex = 2;
            // 
            // UserN_label
            // 
            this.UserN_label.Font = new System.Drawing.Font("Times New Roman", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserN_label.ForeColor = System.Drawing.Color.White;
            this.UserN_label.Location = new System.Drawing.Point(237, 0);
            this.UserN_label.Name = "UserN_label";
            this.UserN_label.Size = new System.Drawing.Size(806, 90);
            this.UserN_label.TabIndex = 1;
            this.UserN_label.Text = "Username";
            this.UserN_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LeftLabel
            // 
            this.LeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.LeftLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftLabel.Location = new System.Drawing.Point(0, 93);
            this.LeftLabel.Name = "LeftLabel";
            this.LeftLabel.Size = new System.Drawing.Size(160, 498);
            this.LeftLabel.TabIndex = 1;
            // 
            // FlowFeatures
            // 
            this.FlowFeatures.BackColor = System.Drawing.Color.Transparent;
            this.FlowFeatures.Controls.Add(this.Picture);
            this.FlowFeatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowFeatures.Location = new System.Drawing.Point(160, 93);
            this.FlowFeatures.Name = "FlowFeatures";
            this.FlowFeatures.Size = new System.Drawing.Size(824, 498);
            this.FlowFeatures.TabIndex = 3;
            // 
            // Picture
            // 
            this.Picture.Image = global::MiniStore.Properties.Resources.background;
            this.Picture.Location = new System.Drawing.Point(3, 3);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(612, 400);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // RightLabel
            // 
            this.RightLabel.BackColor = System.Drawing.Color.Transparent;
            this.RightLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightLabel.Location = new System.Drawing.Point(984, 93);
            this.RightLabel.Name = "RightLabel";
            this.RightLabel.Size = new System.Drawing.Size(160, 498);
            this.RightLabel.TabIndex = 2;
            // 
            // Avatar
            // 
            this.Avatar.BackColor = System.Drawing.Color.DarkGray;
            this.Avatar.InitialImage = null;
            this.Avatar.Location = new System.Drawing.Point(130, 3);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(101, 90);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Avatar.TabIndex = 0;
            this.Avatar.TabStop = false;
            // 
            // FeaturesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.FlowFeatures);
            this.Controls.Add(this.RightLabel);
            this.Controls.Add(this.LeftLabel);
            this.Controls.Add(this.UserPanel);
            this.Name = "FeaturesControl";
            this.Size = new System.Drawing.Size(1144, 591);
            this.UserPanel.ResumeLayout(false);
            this.FlowFeatures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel UserPanel;
        private MiniStore.Costumized.Avatar Avatar;
        private System.Windows.Forms.Label UserN_label;
        private System.Windows.Forms.Label LeftLabel;
        private System.Windows.Forms.FlowLayoutPanel FlowFeatures;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Label NameSpaceLabel;
        private System.Windows.Forms.Label RightLabel;
    }
}
