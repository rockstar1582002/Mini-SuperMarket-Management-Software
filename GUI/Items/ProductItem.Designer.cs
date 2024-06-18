namespace MiniStore.GUI.Items
{
    partial class ProductItem
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
            this.Name_label = new System.Windows.Forms.Label();
            this.Unit_label = new System.Windows.Forms.Label();
            this.Price_label = new System.Windows.Forms.Label();
            this.Category_label = new System.Windows.Forms.Label();
            this.Provider_label = new System.Windows.Forms.Label();
            this.Category_cbo = new System.Windows.Forms.ComboBox();
            this.Image_pic = new System.Windows.Forms.PictureBox();
            this.Provider_cbo = new System.Windows.Forms.ComboBox();
            this.Qty_label = new System.Windows.Forms.Label();
            this.Qty_txt = new MiniStore.Costumized.CostumTextbox();
            this.Image_btn = new MiniStore.Costumized.CostumButton();
            this.Confirm_btn = new MiniStore.Costumized.CostumButton();
            this.Price_txt = new MiniStore.Costumized.CostumTextbox();
            this.Unit_txt = new MiniStore.Costumized.CostumTextbox();
            this.Name_txt = new MiniStore.Costumized.CostumTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.Image_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_label
            // 
            this.Title_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title_label.Font = new System.Drawing.Font("Lucida Handwriting", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Title_label.Location = new System.Drawing.Point(0, 0);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(828, 89);
            this.Title_label.TabIndex = 0;
            this.Title_label.Text = "Product";
            this.Title_label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Name_label
            // 
            this.Name_label.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.ForeColor = System.Drawing.Color.Indigo;
            this.Name_label.Location = new System.Drawing.Point(38, 117);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(165, 35);
            this.Name_label.TabIndex = 1;
            this.Name_label.Text = "Name:";
            this.Name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Unit_label
            // 
            this.Unit_label.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unit_label.ForeColor = System.Drawing.Color.Indigo;
            this.Unit_label.Location = new System.Drawing.Point(38, 176);
            this.Unit_label.Name = "Unit_label";
            this.Unit_label.Size = new System.Drawing.Size(165, 35);
            this.Unit_label.TabIndex = 3;
            this.Unit_label.Text = "Unit:";
            this.Unit_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Price_label
            // 
            this.Price_label.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_label.ForeColor = System.Drawing.Color.Indigo;
            this.Price_label.Location = new System.Drawing.Point(38, 233);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(165, 35);
            this.Price_label.TabIndex = 5;
            this.Price_label.Text = "Price:";
            this.Price_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Category_label
            // 
            this.Category_label.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_label.ForeColor = System.Drawing.Color.Indigo;
            this.Category_label.Location = new System.Drawing.Point(38, 291);
            this.Category_label.Name = "Category_label";
            this.Category_label.Size = new System.Drawing.Size(165, 35);
            this.Category_label.TabIndex = 7;
            this.Category_label.Text = "Category:";
            this.Category_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Provider_label
            // 
            this.Provider_label.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Provider_label.ForeColor = System.Drawing.Color.Indigo;
            this.Provider_label.Location = new System.Drawing.Point(38, 348);
            this.Provider_label.Name = "Provider_label";
            this.Provider_label.Size = new System.Drawing.Size(165, 35);
            this.Provider_label.TabIndex = 8;
            this.Provider_label.Text = "Provider:";
            this.Provider_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Category_cbo
            // 
            this.Category_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category_cbo.Font = new System.Drawing.Font("Lucida Handwriting", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_cbo.FormattingEnabled = true;
            this.Category_cbo.Items.AddRange(new object[] {
            "Food",
            "Drink",
            "Houseware",
            "Cosmetic",
            "Spice"});
            this.Category_cbo.Location = new System.Drawing.Point(210, 290);
            this.Category_cbo.Name = "Category_cbo";
            this.Category_cbo.Size = new System.Drawing.Size(257, 36);
            this.Category_cbo.TabIndex = 10;
            // 
            // Image_pic
            // 
            this.Image_pic.BackColor = System.Drawing.Color.LightGray;
            this.Image_pic.Location = new System.Drawing.Point(579, 117);
            this.Image_pic.Name = "Image_pic";
            this.Image_pic.Size = new System.Drawing.Size(200, 200);
            this.Image_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image_pic.TabIndex = 13;
            this.Image_pic.TabStop = false;
            // 
            // Provider_cbo
            // 
            this.Provider_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Provider_cbo.Font = new System.Drawing.Font("Lucida Handwriting", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Provider_cbo.FormattingEnabled = true;
            this.Provider_cbo.Location = new System.Drawing.Point(210, 348);
            this.Provider_cbo.Name = "Provider_cbo";
            this.Provider_cbo.Size = new System.Drawing.Size(257, 36);
            this.Provider_cbo.TabIndex = 14;
            // 
            // Qty_label
            // 
            this.Qty_label.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty_label.ForeColor = System.Drawing.Color.Indigo;
            this.Qty_label.Location = new System.Drawing.Point(38, 403);
            this.Qty_label.Name = "Qty_label";
            this.Qty_label.Size = new System.Drawing.Size(165, 35);
            this.Qty_label.TabIndex = 15;
            this.Qty_label.Text = "Price:";
            this.Qty_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Qty_txt
            // 
            this.Qty_txt.BackColor = System.Drawing.SystemColors.Window;
            this.Qty_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Qty_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Qty_txt.BorderSize = 2;
            this.Qty_txt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty_txt.ForeColor = System.Drawing.Color.Black;
            this.Qty_txt.IsFocused = false;
            this.Qty_txt.Location = new System.Drawing.Point(210, 403);
            this.Qty_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Qty_txt.Multiline = false;
            this.Qty_txt.Name = "Qty_txt";
            this.Qty_txt.Padding = new System.Windows.Forms.Padding(7);
            this.Qty_txt.PasswordChar = false;
            this.Qty_txt.Size = new System.Drawing.Size(257, 41);
            this.Qty_txt.TabIndex = 16;
            this.Qty_txt.Texts = "";
            this.Qty_txt.UnderlinedStyle = false;
            // 
            // Image_btn
            // 
            this.Image_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Image_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Image_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Image_btn.BorderRadius = 20;
            this.Image_btn.BorderSize = 0;
            this.Image_btn.FlatAppearance.BorderSize = 0;
            this.Image_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Image_btn.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Image_btn.ForeColor = System.Drawing.Color.White;
            this.Image_btn.Location = new System.Drawing.Point(579, 341);
            this.Image_btn.Name = "Image_btn";
            this.Image_btn.Size = new System.Drawing.Size(200, 47);
            this.Image_btn.TabIndex = 12;
            this.Image_btn.Text = "Choose Image";
            this.Image_btn.TextColor = System.Drawing.Color.White;
            this.Image_btn.UseVisualStyleBackColor = false;
            this.Image_btn.Click += new System.EventHandler(this.Image_btn_Click);
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
            this.Confirm_btn.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_btn.ForeColor = System.Drawing.Color.White;
            this.Confirm_btn.Location = new System.Drawing.Point(319, 462);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(199, 48);
            this.Confirm_btn.TabIndex = 11;
            this.Confirm_btn.Text = "Confirm";
            this.Confirm_btn.TextColor = System.Drawing.Color.White;
            this.Confirm_btn.UseVisualStyleBackColor = false;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // Price_txt
            // 
            this.Price_txt.BackColor = System.Drawing.SystemColors.Window;
            this.Price_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Price_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Price_txt.BorderSize = 2;
            this.Price_txt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_txt.ForeColor = System.Drawing.Color.Black;
            this.Price_txt.IsFocused = false;
            this.Price_txt.Location = new System.Drawing.Point(210, 233);
            this.Price_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Price_txt.Multiline = false;
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.Padding = new System.Windows.Forms.Padding(7);
            this.Price_txt.PasswordChar = false;
            this.Price_txt.Size = new System.Drawing.Size(257, 41);
            this.Price_txt.TabIndex = 6;
            this.Price_txt.Texts = "";
            this.Price_txt.UnderlinedStyle = false;
            // 
            // Unit_txt
            // 
            this.Unit_txt.BackColor = System.Drawing.SystemColors.Window;
            this.Unit_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Unit_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Unit_txt.BorderSize = 2;
            this.Unit_txt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unit_txt.ForeColor = System.Drawing.Color.Black;
            this.Unit_txt.IsFocused = false;
            this.Unit_txt.Location = new System.Drawing.Point(210, 176);
            this.Unit_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Unit_txt.Multiline = false;
            this.Unit_txt.Name = "Unit_txt";
            this.Unit_txt.Padding = new System.Windows.Forms.Padding(7);
            this.Unit_txt.PasswordChar = false;
            this.Unit_txt.Size = new System.Drawing.Size(257, 41);
            this.Unit_txt.TabIndex = 4;
            this.Unit_txt.Texts = "";
            this.Unit_txt.UnderlinedStyle = false;
            // 
            // Name_txt
            // 
            this.Name_txt.BackColor = System.Drawing.SystemColors.Window;
            this.Name_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Name_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Name_txt.BorderSize = 2;
            this.Name_txt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_txt.ForeColor = System.Drawing.Color.Black;
            this.Name_txt.IsFocused = false;
            this.Name_txt.Location = new System.Drawing.Point(210, 117);
            this.Name_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Name_txt.Multiline = false;
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Padding = new System.Windows.Forms.Padding(7);
            this.Name_txt.PasswordChar = false;
            this.Name_txt.Size = new System.Drawing.Size(257, 41);
            this.Name_txt.TabIndex = 2;
            this.Name_txt.Texts = "";
            this.Name_txt.UnderlinedStyle = false;
            // 
            // ProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Qty_txt);
            this.Controls.Add(this.Qty_label);
            this.Controls.Add(this.Provider_cbo);
            this.Controls.Add(this.Image_pic);
            this.Controls.Add(this.Image_btn);
            this.Controls.Add(this.Confirm_btn);
            this.Controls.Add(this.Category_cbo);
            this.Controls.Add(this.Provider_label);
            this.Controls.Add(this.Category_label);
            this.Controls.Add(this.Price_txt);
            this.Controls.Add(this.Price_label);
            this.Controls.Add(this.Unit_txt);
            this.Controls.Add(this.Unit_label);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Title_label);
            this.Name = "ProductItem";
            this.Size = new System.Drawing.Size(828, 565);
            ((System.ComponentModel.ISupportInitialize)(this.Image_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Label Name_label;
        private Costumized.CostumTextbox Name_txt;
        private Costumized.CostumTextbox Unit_txt;
        private System.Windows.Forms.Label Unit_label;
        private Costumized.CostumTextbox Price_txt;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.Label Category_label;
        private System.Windows.Forms.Label Provider_label;
        private System.Windows.Forms.ComboBox Category_cbo;
        private Costumized.CostumButton Confirm_btn;
        private Costumized.CostumButton Image_btn;
        private System.Windows.Forms.PictureBox Image_pic;
        private System.Windows.Forms.ComboBox Provider_cbo;
        private Costumized.CostumTextbox Qty_txt;
        private System.Windows.Forms.Label Qty_label;
    }
}
