namespace MiniStore.GUI.Features
{
    partial class ConsumerItem
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
            this.Title = new System.Windows.Forms.Label();
            this.Phone_label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.Points_label = new System.Windows.Forms.Label();
            this.Birth_label = new System.Windows.Forms.Label();
            this.Birth_DTP = new System.Windows.Forms.DateTimePicker();
            this.Confirm_btn = new MiniStore.Costumized.CostumButton();
            this.Points_txt = new MiniStore.Costumized.CostumTextbox();
            this.Name_txt = new MiniStore.Costumized.CostumTextbox();
            this.Phone_txt = new MiniStore.Costumized.CostumTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Title.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(552, 102);
            this.Title.TabIndex = 0;
            this.Title.Text = "Consumer Setting";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Phone_label
            // 
            this.Phone_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Phone_label.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_label.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Phone_label.Location = new System.Drawing.Point(50, 109);
            this.Phone_label.Name = "Phone_label";
            this.Phone_label.Size = new System.Drawing.Size(171, 39);
            this.Phone_label.TabIndex = 3;
            this.Phone_label.Text = "Number:";
            this.Phone_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Name_label
            // 
            this.Name_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Name_label.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Name_label.Location = new System.Drawing.Point(50, 178);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(171, 39);
            this.Name_label.TabIndex = 5;
            this.Name_label.Text = "Name:";
            this.Name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Points_label
            // 
            this.Points_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Points_label.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Points_label.Location = new System.Drawing.Point(55, 248);
            this.Points_label.Name = "Points_label";
            this.Points_label.Size = new System.Drawing.Size(166, 39);
            this.Points_label.TabIndex = 7;
            this.Points_label.Text = "Points:";
            this.Points_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Birth_label
            // 
            this.Birth_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Birth_label.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birth_label.Location = new System.Drawing.Point(41, 321);
            this.Birth_label.Name = "Birth_label";
            this.Birth_label.Size = new System.Drawing.Size(203, 39);
            this.Birth_label.TabIndex = 9;
            this.Birth_label.Text = "BirthDay:";
            this.Birth_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Birth_DTP
            // 
            this.Birth_DTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Birth_DTP.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birth_DTP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birth_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Birth_DTP.Location = new System.Drawing.Point(251, 323);
            this.Birth_DTP.Name = "Birth_DTP";
            this.Birth_DTP.Size = new System.Drawing.Size(263, 30);
            this.Birth_DTP.TabIndex = 10;
            this.Birth_DTP.Value = new System.DateTime(2022, 11, 28, 22, 7, 59, 0);
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.Confirm_btn.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.Confirm_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Confirm_btn.BorderRadius = 20;
            this.Confirm_btn.BorderSize = 0;
            this.Confirm_btn.FlatAppearance.BorderSize = 0;
            this.Confirm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm_btn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_btn.ForeColor = System.Drawing.Color.White;
            this.Confirm_btn.Location = new System.Drawing.Point(160, 396);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(198, 61);
            this.Confirm_btn.TabIndex = 11;
            this.Confirm_btn.Text = "Confirm";
            this.Confirm_btn.TextColor = System.Drawing.Color.White;
            this.Confirm_btn.UseVisualStyleBackColor = false;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // Points_txt
            // 
            this.Points_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Points_txt.BackColor = System.Drawing.SystemColors.Window;
            this.Points_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Points_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Points_txt.BorderSize = 2;
            this.Points_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Points_txt.ForeColor = System.Drawing.Color.Black;
            this.Points_txt.IsFocused = false;
            this.Points_txt.Location = new System.Drawing.Point(251, 248);
            this.Points_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Points_txt.Multiline = false;
            this.Points_txt.Name = "Points_txt";
            this.Points_txt.Padding = new System.Windows.Forms.Padding(7);
            this.Points_txt.PasswordChar = false;
            this.Points_txt.Size = new System.Drawing.Size(263, 41);
            this.Points_txt.TabIndex = 8;
            this.Points_txt.Texts = "";
            this.Points_txt.UnderlinedStyle = true;
            // 
            // Name_txt
            // 
            this.Name_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Name_txt.BackColor = System.Drawing.SystemColors.Window;
            this.Name_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Name_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Name_txt.BorderSize = 2;
            this.Name_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_txt.ForeColor = System.Drawing.Color.Black;
            this.Name_txt.IsFocused = false;
            this.Name_txt.Location = new System.Drawing.Point(251, 178);
            this.Name_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Name_txt.Multiline = false;
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Padding = new System.Windows.Forms.Padding(7);
            this.Name_txt.PasswordChar = false;
            this.Name_txt.Size = new System.Drawing.Size(263, 41);
            this.Name_txt.TabIndex = 6;
            this.Name_txt.Texts = "";
            this.Name_txt.UnderlinedStyle = true;
            // 
            // Phone_txt
            // 
            this.Phone_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Phone_txt.BackColor = System.Drawing.SystemColors.Window;
            this.Phone_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Phone_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Phone_txt.BorderSize = 2;
            this.Phone_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_txt.ForeColor = System.Drawing.Color.Black;
            this.Phone_txt.IsFocused = false;
            this.Phone_txt.Location = new System.Drawing.Point(251, 109);
            this.Phone_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Phone_txt.Multiline = false;
            this.Phone_txt.Name = "Phone_txt";
            this.Phone_txt.Padding = new System.Windows.Forms.Padding(7);
            this.Phone_txt.PasswordChar = false;
            this.Phone_txt.Size = new System.Drawing.Size(263, 41);
            this.Phone_txt.TabIndex = 4;
            this.Phone_txt.Texts = "";
            this.Phone_txt.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(36, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Location = new System.Drawing.Point(36, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Points:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConsumerItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Confirm_btn);
            this.Controls.Add(this.Birth_DTP);
            this.Controls.Add(this.Birth_label);
            this.Controls.Add(this.Points_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Points_label);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Phone_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Phone_label);
            this.Controls.Add(this.Title);
            this.Name = "ConsumerItem";
            this.Size = new System.Drawing.Size(552, 488);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private Costumized.CostumTextbox Phone_txt;
        private System.Windows.Forms.Label Phone_label;
        private Costumized.CostumTextbox Name_txt;
        private System.Windows.Forms.Label Name_label;
        private Costumized.CostumTextbox Points_txt;
        private System.Windows.Forms.Label Points_label;
        private System.Windows.Forms.Label Birth_label;
        private System.Windows.Forms.DateTimePicker Birth_DTP;
        private Costumized.CostumButton Confirm_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
