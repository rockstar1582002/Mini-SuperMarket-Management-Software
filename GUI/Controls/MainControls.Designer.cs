namespace MiniStore
{
    partial class MainControl
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.FeaturePanel = new System.Windows.Forms.Panel();
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Space = new System.Windows.Forms.Panel();
            this.avatar = new MiniStore.Costumized.Avatar();
            this.PublicFeaturePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Exit_btn = new FontAwesome.Sharp.IconPictureBox();
            this.MainPanel.SuspendLayout();
            this.ToolPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.Space.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.PublicFeaturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.FeaturePanel);
            this.MainPanel.Controls.Add(this.ToolPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1161, 565);
            this.MainPanel.TabIndex = 0;
            // 
            // FeaturePanel
            // 
            this.FeaturePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FeaturePanel.Location = new System.Drawing.Point(105, 0);
            this.FeaturePanel.Name = "FeaturePanel";
            this.FeaturePanel.Size = new System.Drawing.Size(1056, 565);
            this.FeaturePanel.TabIndex = 1;
            // 
            // ToolPanel
            // 
            this.ToolPanel.Controls.Add(this.LeftPanel);
            this.ToolPanel.Controls.Add(this.PublicFeaturePanel);
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(105, 565);
            this.ToolPanel.TabIndex = 2;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.SlateBlue;
            this.LeftPanel.Controls.Add(this.Space);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(105, 460);
            this.LeftPanel.TabIndex = 0;
            // 
            // Space
            // 
            this.Space.BackColor = System.Drawing.Color.Transparent;
            this.Space.Controls.Add(this.avatar);
            this.Space.Dock = System.Windows.Forms.DockStyle.Top;
            this.Space.Location = new System.Drawing.Point(0, 0);
            this.Space.Margin = new System.Windows.Forms.Padding(0);
            this.Space.Name = "Space";
            this.Space.Size = new System.Drawing.Size(105, 111);
            this.Space.TabIndex = 1;
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.Color.DarkGray;
            this.avatar.Location = new System.Drawing.Point(2, 5);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(100, 95);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            // 
            // PublicFeaturePanel
            // 
            this.PublicFeaturePanel.BackColor = System.Drawing.Color.SlateBlue;
            this.PublicFeaturePanel.Controls.Add(this.Exit_btn);
            this.PublicFeaturePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PublicFeaturePanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.PublicFeaturePanel.Location = new System.Drawing.Point(0, 460);
            this.PublicFeaturePanel.Name = "PublicFeaturePanel";
            this.PublicFeaturePanel.Size = new System.Drawing.Size(105, 105);
            this.PublicFeaturePanel.TabIndex = 0;
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.Exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit_btn.ForeColor = System.Drawing.Color.OrangeRed;
            this.Exit_btn.IconChar = FontAwesome.Sharp.IconChar.CircleArrowLeft;
            this.Exit_btn.IconColor = System.Drawing.Color.OrangeRed;
            this.Exit_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Exit_btn.IconSize = 105;
            this.Exit_btn.Location = new System.Drawing.Point(3, -3);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(105, 105);
            this.Exit_btn.TabIndex = 2;
            this.Exit_btn.TabStop = false;
            this.Exit_btn.UseGdi = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.MainPanel);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(1161, 565);
            this.MainPanel.ResumeLayout(false);
            this.ToolPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.Space.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.PublicFeaturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ToolPanel;
        private FontAwesome.Sharp.IconPictureBox Exit_btn;
        private System.Windows.Forms.FlowLayoutPanel LeftPanel;
        private System.Windows.Forms.Panel Space;
        private System.Windows.Forms.Panel FeaturePanel;
        private System.Windows.Forms.FlowLayoutPanel PublicFeaturePanel;
        private Costumized.Avatar avatar;
    }
}
