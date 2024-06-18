namespace MiniStore.GUI.Items
{
    partial class PasswordEnter
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
            this.Title_label = new System.Windows.Forms.Label();
            this.passwd_label = new System.Windows.Forms.Label();
            this.Passwd_txt = new MiniStore.Costumized.CostumTextbox();
            this.Ok_btn = new MiniStore.Costumized.CostumButton();
            this.SuspendLayout();
            // 
            // Title_label
            // 
            this.Title_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title_label.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Title_label.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Title_label.Location = new System.Drawing.Point(0, 0);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(635, 58);
            this.Title_label.TabIndex = 0;
            this.Title_label.Text = "Enter your password to confirm";
            this.Title_label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // passwd_label
            // 
            this.passwd_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwd_label.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwd_label.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.passwd_label.Location = new System.Drawing.Point(116, 107);
            this.passwd_label.Name = "passwd_label";
            this.passwd_label.Size = new System.Drawing.Size(146, 39);
            this.passwd_label.TabIndex = 1;
            this.passwd_label.Text = "Password:";
            this.passwd_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Passwd_txt
            // 
            this.Passwd_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Passwd_txt.BackColor = System.Drawing.SystemColors.Window;
            this.Passwd_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Passwd_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Passwd_txt.BorderSize = 2;
            this.Passwd_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwd_txt.ForeColor = System.Drawing.Color.DimGray;
            this.Passwd_txt.IsFocused = false;
            this.Passwd_txt.Location = new System.Drawing.Point(269, 107);
            this.Passwd_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Passwd_txt.Multiline = false;
            this.Passwd_txt.Name = "Passwd_txt";
            this.Passwd_txt.Padding = new System.Windows.Forms.Padding(7);
            this.Passwd_txt.PasswordChar = true;
            this.Passwd_txt.Size = new System.Drawing.Size(250, 35);
            this.Passwd_txt.TabIndex = 2;
            this.Passwd_txt.Texts = "";
            this.Passwd_txt.UnderlinedStyle = true;
            // 
            // Ok_btn
            // 
            this.Ok_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ok_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Ok_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Ok_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Ok_btn.BorderRadius = 20;
            this.Ok_btn.BorderSize = 0;
            this.Ok_btn.FlatAppearance.BorderSize = 0;
            this.Ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok_btn.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ok_btn.ForeColor = System.Drawing.Color.White;
            this.Ok_btn.Location = new System.Drawing.Point(244, 169);
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.Size = new System.Drawing.Size(164, 51);
            this.Ok_btn.TabIndex = 3;
            this.Ok_btn.Text = "OK";
            this.Ok_btn.TextColor = System.Drawing.Color.White;
            this.Ok_btn.UseVisualStyleBackColor = false;
            this.Ok_btn.Click += new System.EventHandler(this.Ok_btn_Click);
            // 
            // PasswordEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Ok_btn);
            this.Controls.Add(this.Passwd_txt);
            this.Controls.Add(this.passwd_label);
            this.Controls.Add(this.Title_label);
            this.Name = "PasswordEnter";
            this.Size = new System.Drawing.Size(635, 265);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Label passwd_label;
        private Costumized.CostumTextbox Passwd_txt;
        private Costumized.CostumButton Ok_btn;
    }
}
