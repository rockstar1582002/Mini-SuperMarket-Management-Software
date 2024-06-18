namespace MiniStore.GUI
{
    partial class LoginControl
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
            this.LoginPanel = new MiniStore.Costumized.GPanel();
            this.UserN_txt = new MiniStore.Costumized.CostumTextbox();
            this.Pass_txt = new MiniStore.Costumized.CostumTextbox();
            this.IconPanel = new System.Windows.Forms.Panel();
            this.Icon_picture = new System.Windows.Forms.PictureBox();
            this.Login_btn = new MiniStore.Costumized.CostumButton();
            this.Pass_label = new System.Windows.Forms.Label();
            this.UserN_label = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.IconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginPanel.BackColor = System.Drawing.Color.White;
            this.LoginPanel.BorderRadius = 30;
            this.LoginPanel.Controls.Add(this.UserN_txt);
            this.LoginPanel.Controls.Add(this.Pass_txt);
            this.LoginPanel.Controls.Add(this.IconPanel);
            this.LoginPanel.Controls.Add(this.Login_btn);
            this.LoginPanel.Controls.Add(this.Pass_label);
            this.LoginPanel.Controls.Add(this.UserN_label);
            this.LoginPanel.ForeColor = System.Drawing.Color.Black;
            this.LoginPanel.GradientAngle = 90F;
            this.LoginPanel.GradientBottomColor = System.Drawing.Color.MediumPurple;
            this.LoginPanel.GradientTopColor = System.Drawing.Color.DarkBlue;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(524, 562);
            this.LoginPanel.TabIndex = 0;
            // 
            // UserN_txt
            // 
            this.UserN_txt.BackColor = System.Drawing.SystemColors.Window;
            this.UserN_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.UserN_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.UserN_txt.BorderSize = 2;
            this.UserN_txt.Font = new System.Drawing.Font("Lucida Bright", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserN_txt.ForeColor = System.Drawing.Color.Black;
            this.UserN_txt.IsFocused = false;
            this.UserN_txt.Location = new System.Drawing.Point(213, 242);
            this.UserN_txt.Margin = new System.Windows.Forms.Padding(4);
            this.UserN_txt.Multiline = false;
            this.UserN_txt.Name = "UserN_txt";
            this.UserN_txt.Padding = new System.Windows.Forms.Padding(7);
            this.UserN_txt.PasswordChar = false;
            this.UserN_txt.Size = new System.Drawing.Size(262, 40);
            this.UserN_txt.TabIndex = 6;
            this.UserN_txt.Texts = "";
            this.UserN_txt.UnderlinedStyle = false;
            // 
            // Pass_txt
            // 
            this.Pass_txt.BackColor = System.Drawing.SystemColors.Window;
            this.Pass_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Pass_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Pass_txt.BorderSize = 2;
            this.Pass_txt.Font = new System.Drawing.Font("Lucida Bright", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_txt.ForeColor = System.Drawing.Color.Black;
            this.Pass_txt.IsFocused = false;
            this.Pass_txt.Location = new System.Drawing.Point(213, 306);
            this.Pass_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Pass_txt.Multiline = false;
            this.Pass_txt.Name = "Pass_txt";
            this.Pass_txt.Padding = new System.Windows.Forms.Padding(7);
            this.Pass_txt.PasswordChar = true;
            this.Pass_txt.Size = new System.Drawing.Size(262, 40);
            this.Pass_txt.TabIndex = 7;
            this.Pass_txt.Texts = "";
            this.Pass_txt.UnderlinedStyle = false;
            // 
            // IconPanel
            // 
            this.IconPanel.BackColor = System.Drawing.Color.Transparent;
            this.IconPanel.Controls.Add(this.Icon_picture);
            this.IconPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.IconPanel.Location = new System.Drawing.Point(0, 0);
            this.IconPanel.Name = "IconPanel";
            this.IconPanel.Size = new System.Drawing.Size(524, 180);
            this.IconPanel.TabIndex = 5;
            // 
            // Icon_picture
            // 
            this.Icon_picture.BackgroundImage = global::MiniStore.Properties.Resources.ShopIcon;
            this.Icon_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Icon_picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Icon_picture.Location = new System.Drawing.Point(0, 0);
            this.Icon_picture.Name = "Icon_picture";
            this.Icon_picture.Size = new System.Drawing.Size(524, 180);
            this.Icon_picture.TabIndex = 6;
            this.Icon_picture.TabStop = false;
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Login_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Login_btn.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.Login_btn.BorderRadius = 20;
            this.Login_btn.BorderSize = 2;
            this.Login_btn.FlatAppearance.BorderSize = 0;
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.ForeColor = System.Drawing.Color.White;
            this.Login_btn.Location = new System.Drawing.Point(110, 419);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(311, 64);
            this.Login_btn.TabIndex = 8;
            this.Login_btn.Text = "Login";
            this.Login_btn.TextColor = System.Drawing.Color.White;
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Pass_label
            // 
            this.Pass_label.AutoSize = true;
            this.Pass_label.BackColor = System.Drawing.Color.Transparent;
            this.Pass_label.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_label.ForeColor = System.Drawing.Color.White;
            this.Pass_label.Location = new System.Drawing.Point(24, 315);
            this.Pass_label.Name = "Pass_label";
            this.Pass_label.Size = new System.Drawing.Size(133, 27);
            this.Pass_label.TabIndex = 3;
            this.Pass_label.Text = "Password:";
            // 
            // UserN_label
            // 
            this.UserN_label.AutoSize = true;
            this.UserN_label.BackColor = System.Drawing.Color.Transparent;
            this.UserN_label.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserN_label.ForeColor = System.Drawing.Color.White;
            this.UserN_label.Location = new System.Drawing.Point(24, 242);
            this.UserN_label.Name = "UserN_label";
            this.UserN_label.Size = new System.Drawing.Size(143, 27);
            this.UserN_label.TabIndex = 1;
            this.UserN_label.Text = "Username:";
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LoginPanel);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(524, 562);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.IconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Icon_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MiniStore.Costumized.GPanel LoginPanel;
        private System.Windows.Forms.Label Pass_label;
        private System.Windows.Forms.Label UserN_label;
        private MiniStore.Costumized.CostumButton Login_btn;
        private System.Windows.Forms.Panel IconPanel;
        private System.Windows.Forms.PictureBox Icon_picture;
        private MiniStore.Costumized.CostumTextbox UserN_txt;
        private MiniStore.Costumized.CostumTextbox Pass_txt;
    }
}
