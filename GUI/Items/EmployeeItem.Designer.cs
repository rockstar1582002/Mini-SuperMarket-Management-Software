namespace MiniStore.GUI.Controls
{
    partial class EmployeeItem
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
            this.MainPanel = new MiniStore.Costumized.GPanel();
            this.Image_btn = new MiniStore.Costumized.CostumButton();
            this.Avatar = new MiniStore.Costumized.Avatar();
            this.Cancel_btn = new MiniStore.Costumized.CostumButton();
            this.Save_btn = new MiniStore.Costumized.CostumButton();
            this.Role_cbo = new System.Windows.Forms.ComboBox();
            this.Role_Label = new System.Windows.Forms.Label();
            this.Phone_txt = new MiniStore.Costumized.CostumTextbox();
            this.Phone_label = new System.Windows.Forms.Label();
            this.Name_txt = new MiniStore.Costumized.CostumTextbox();
            this.Name_label = new System.Windows.Forms.Label();
            this.Passwd_txt = new MiniStore.Costumized.CostumTextbox();
            this.Passwd_label = new System.Windows.Forms.Label();
            this.UserN_txt = new MiniStore.Costumized.CostumTextbox();
            this.UserN_label = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.BorderRadius = 30;
            this.MainPanel.Controls.Add(this.Image_btn);
            this.MainPanel.Controls.Add(this.Avatar);
            this.MainPanel.Controls.Add(this.Cancel_btn);
            this.MainPanel.Controls.Add(this.Save_btn);
            this.MainPanel.Controls.Add(this.Role_cbo);
            this.MainPanel.Controls.Add(this.Role_Label);
            this.MainPanel.Controls.Add(this.Phone_txt);
            this.MainPanel.Controls.Add(this.Phone_label);
            this.MainPanel.Controls.Add(this.Name_txt);
            this.MainPanel.Controls.Add(this.Name_label);
            this.MainPanel.Controls.Add(this.Passwd_txt);
            this.MainPanel.Controls.Add(this.Passwd_label);
            this.MainPanel.Controls.Add(this.UserN_txt);
            this.MainPanel.Controls.Add(this.UserN_label);
            this.MainPanel.ForeColor = System.Drawing.Color.Black;
            this.MainPanel.GradientAngle = 90F;
            this.MainPanel.GradientBottomColor = System.Drawing.Color.MediumPurple;
            this.MainPanel.GradientTopColor = System.Drawing.Color.DarkSlateBlue;
            this.MainPanel.Location = new System.Drawing.Point(62, 9);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1090, 501);
            this.MainPanel.TabIndex = 0;
            // 
            // Image_btn
            // 
            this.Image_btn.BackColor = System.Drawing.Color.Orchid;
            this.Image_btn.BackgroundColor = System.Drawing.Color.Orchid;
            this.Image_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Image_btn.BorderRadius = 20;
            this.Image_btn.BorderSize = 0;
            this.Image_btn.FlatAppearance.BorderSize = 0;
            this.Image_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Image_btn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Image_btn.ForeColor = System.Drawing.Color.Black;
            this.Image_btn.Location = new System.Drawing.Point(808, 303);
            this.Image_btn.Name = "Image_btn";
            this.Image_btn.Size = new System.Drawing.Size(237, 51);
            this.Image_btn.TabIndex = 25;
            this.Image_btn.Text = "Choose Image";
            this.Image_btn.TextColor = System.Drawing.Color.Black;
            this.Image_btn.UseVisualStyleBackColor = false;
            this.Image_btn.Click += new System.EventHandler(this.Image_btn_Click);
            // 
            // Avatar
            // 
            this.Avatar.BackColor = System.Drawing.Color.DarkGray;
            this.Avatar.Location = new System.Drawing.Point(808, 66);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(237, 217);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Avatar.TabIndex = 24;
            this.Avatar.TabStop = false;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.Color.Crimson;
            this.Cancel_btn.BackgroundColor = System.Drawing.Color.Crimson;
            this.Cancel_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Cancel_btn.BorderRadius = 20;
            this.Cancel_btn.BorderSize = 0;
            this.Cancel_btn.FlatAppearance.BorderSize = 0;
            this.Cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_btn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_btn.ForeColor = System.Drawing.Color.White;
            this.Cancel_btn.Location = new System.Drawing.Point(274, 408);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(183, 57);
            this.Cancel_btn.TabIndex = 23;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.TextColor = System.Drawing.Color.White;
            this.Cancel_btn.UseVisualStyleBackColor = false;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.Save_btn.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.Save_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Save_btn.BorderRadius = 20;
            this.Save_btn.BorderSize = 0;
            this.Save_btn.FlatAppearance.BorderSize = 0;
            this.Save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_btn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.ForeColor = System.Drawing.Color.White;
            this.Save_btn.Location = new System.Drawing.Point(490, 408);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(183, 57);
            this.Save_btn.TabIndex = 22;
            this.Save_btn.Text = "Save";
            this.Save_btn.TextColor = System.Drawing.Color.White;
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Role_cbo
            // 
            this.Role_cbo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Role_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Role_cbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Role_cbo.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role_cbo.ForeColor = System.Drawing.Color.Black;
            this.Role_cbo.FormattingEnabled = true;
            this.Role_cbo.IntegralHeight = false;
            this.Role_cbo.ItemHeight = 25;
            this.Role_cbo.Items.AddRange(new object[] {
            "Manager",
            "Inventory",
            "Cashier",
            "Administrator"});
            this.Role_cbo.Location = new System.Drawing.Point(287, 321);
            this.Role_cbo.Name = "Role_cbo";
            this.Role_cbo.Size = new System.Drawing.Size(195, 33);
            this.Role_cbo.TabIndex = 21;
            // 
            // Role_Label
            // 
            this.Role_Label.BackColor = System.Drawing.Color.Transparent;
            this.Role_Label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role_Label.ForeColor = System.Drawing.Color.White;
            this.Role_Label.Location = new System.Drawing.Point(30, 316);
            this.Role_Label.Name = "Role_Label";
            this.Role_Label.Size = new System.Drawing.Size(234, 38);
            this.Role_Label.TabIndex = 20;
            this.Role_Label.Text = "Permission:";
            this.Role_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Phone_txt
            // 
            this.Phone_txt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Phone_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Phone_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Phone_txt.BorderSize = 2;
            this.Phone_txt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_txt.ForeColor = System.Drawing.Color.Black;
            this.Phone_txt.IsFocused = false;
            this.Phone_txt.Location = new System.Drawing.Point(287, 245);
            this.Phone_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Phone_txt.Multiline = false;
            this.Phone_txt.Name = "Phone_txt";
            this.Phone_txt.Padding = new System.Windows.Forms.Padding(7);
            this.Phone_txt.PasswordChar = false;
            this.Phone_txt.Size = new System.Drawing.Size(458, 41);
            this.Phone_txt.TabIndex = 19;
            this.Phone_txt.Texts = "";
            this.Phone_txt.UnderlinedStyle = false;
            // 
            // Phone_label
            // 
            this.Phone_label.BackColor = System.Drawing.Color.Transparent;
            this.Phone_label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_label.ForeColor = System.Drawing.Color.White;
            this.Phone_label.Location = new System.Drawing.Point(30, 245);
            this.Phone_label.Name = "Phone_label";
            this.Phone_label.Size = new System.Drawing.Size(211, 38);
            this.Phone_label.TabIndex = 18;
            this.Phone_label.Text = "Phone:";
            this.Phone_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Name_txt
            // 
            this.Name_txt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Name_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Name_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Name_txt.BorderSize = 2;
            this.Name_txt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_txt.ForeColor = System.Drawing.Color.Black;
            this.Name_txt.IsFocused = false;
            this.Name_txt.Location = new System.Drawing.Point(287, 177);
            this.Name_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Name_txt.Multiline = false;
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Padding = new System.Windows.Forms.Padding(7);
            this.Name_txt.PasswordChar = false;
            this.Name_txt.Size = new System.Drawing.Size(458, 41);
            this.Name_txt.TabIndex = 17;
            this.Name_txt.Texts = "";
            this.Name_txt.UnderlinedStyle = false;
            // 
            // Name_label
            // 
            this.Name_label.BackColor = System.Drawing.Color.Transparent;
            this.Name_label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.ForeColor = System.Drawing.Color.White;
            this.Name_label.Location = new System.Drawing.Point(30, 177);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(211, 38);
            this.Name_label.TabIndex = 16;
            this.Name_label.Text = "Name:";
            this.Name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Passwd_txt
            // 
            this.Passwd_txt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Passwd_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Passwd_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Passwd_txt.BorderSize = 2;
            this.Passwd_txt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwd_txt.ForeColor = System.Drawing.Color.Black;
            this.Passwd_txt.IsFocused = false;
            this.Passwd_txt.Location = new System.Drawing.Point(287, 109);
            this.Passwd_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Passwd_txt.Multiline = false;
            this.Passwd_txt.Name = "Passwd_txt";
            this.Passwd_txt.Padding = new System.Windows.Forms.Padding(7);
            this.Passwd_txt.PasswordChar = true;
            this.Passwd_txt.Size = new System.Drawing.Size(458, 41);
            this.Passwd_txt.TabIndex = 15;
            this.Passwd_txt.Texts = "";
            this.Passwd_txt.UnderlinedStyle = false;
            // 
            // Passwd_label
            // 
            this.Passwd_label.BackColor = System.Drawing.Color.Transparent;
            this.Passwd_label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwd_label.ForeColor = System.Drawing.Color.White;
            this.Passwd_label.Location = new System.Drawing.Point(30, 109);
            this.Passwd_label.Name = "Passwd_label";
            this.Passwd_label.Size = new System.Drawing.Size(211, 38);
            this.Passwd_label.TabIndex = 14;
            this.Passwd_label.Text = "Password:";
            this.Passwd_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserN_txt
            // 
            this.UserN_txt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UserN_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.UserN_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.UserN_txt.BorderSize = 2;
            this.UserN_txt.Enabled = false;
            this.UserN_txt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserN_txt.ForeColor = System.Drawing.Color.Black;
            this.UserN_txt.IsFocused = false;
            this.UserN_txt.Location = new System.Drawing.Point(287, 43);
            this.UserN_txt.Margin = new System.Windows.Forms.Padding(4);
            this.UserN_txt.Multiline = false;
            this.UserN_txt.Name = "UserN_txt";
            this.UserN_txt.Padding = new System.Windows.Forms.Padding(7);
            this.UserN_txt.PasswordChar = false;
            this.UserN_txt.Size = new System.Drawing.Size(458, 41);
            this.UserN_txt.TabIndex = 13;
            this.UserN_txt.Texts = "";
            this.UserN_txt.UnderlinedStyle = false;
            // 
            // UserN_label
            // 
            this.UserN_label.BackColor = System.Drawing.Color.Transparent;
            this.UserN_label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserN_label.ForeColor = System.Drawing.Color.White;
            this.UserN_label.Location = new System.Drawing.Point(30, 43);
            this.UserN_label.Name = "UserN_label";
            this.UserN_label.Size = new System.Drawing.Size(234, 38);
            this.UserN_label.TabIndex = 12;
            this.UserN_label.Text = "Username:";
            this.UserN_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmployeeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.MainPanel);
            this.Name = "EmployeeItem";
            this.Size = new System.Drawing.Size(1212, 550);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Costumized.GPanel MainPanel;
        private Costumized.CostumButton Cancel_btn;
        private Costumized.CostumButton Save_btn;
        private System.Windows.Forms.ComboBox Role_cbo;
        private System.Windows.Forms.Label Role_Label;
        private Costumized.CostumTextbox Phone_txt;
        private System.Windows.Forms.Label Phone_label;
        private Costumized.CostumTextbox Name_txt;
        private System.Windows.Forms.Label Name_label;
        private Costumized.CostumTextbox Passwd_txt;
        private System.Windows.Forms.Label Passwd_label;
        private Costumized.CostumTextbox UserN_txt;
        private System.Windows.Forms.Label UserN_label;
        private Costumized.Avatar Avatar;
        private Costumized.CostumButton Image_btn;
    }
}
