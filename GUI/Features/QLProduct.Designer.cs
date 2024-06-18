namespace Kho
{
    partial class QLProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Product_gridview = new System.Windows.Forms.DataGridView();
            this.Tool_panel = new System.Windows.Forms.Panel();
            this.Remove_btn = new MiniStore.Costumized.CostumButton();
            this.Edit_btn = new MiniStore.Costumized.CostumButton();
            this.Add_btn = new MiniStore.Costumized.CostumButton();
            this.Search_btn = new MiniStore.Costumized.CostumButton();
            this.Filter_cbo = new System.Windows.Forms.ComboBox();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product_gridview)).BeginInit();
            this.Tool_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 565);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1161, 510);
            this.panel2.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Product_gridview);
            this.groupBox4.Controls.Add(this.Tool_panel);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox4.Size = new System.Drawing.Size(1161, 510);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Products";
            // 
            // Product_gridview
            // 
            this.Product_gridview.AllowUserToAddRows = false;
            this.Product_gridview.AllowUserToDeleteRows = false;
            this.Product_gridview.AllowUserToResizeColumns = false;
            this.Product_gridview.AllowUserToResizeRows = false;
            this.Product_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Product_gridview.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Product_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Product_gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Product_gridview.Location = new System.Drawing.Point(10, 94);
            this.Product_gridview.Margin = new System.Windows.Forms.Padding(10);
            this.Product_gridview.Name = "Product_gridview";
            this.Product_gridview.ReadOnly = true;
            this.Product_gridview.RowHeadersVisible = false;
            this.Product_gridview.RowHeadersWidth = 51;
            this.Product_gridview.RowTemplate.Height = 24;
            this.Product_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Product_gridview.Size = new System.Drawing.Size(1141, 406);
            this.Product_gridview.TabIndex = 0;
            this.Product_gridview.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Product_gridview_CellMouseDoubleClick);
            // 
            // Tool_panel
            // 
            this.Tool_panel.Controls.Add(this.Remove_btn);
            this.Tool_panel.Controls.Add(this.Edit_btn);
            this.Tool_panel.Controls.Add(this.Add_btn);
            this.Tool_panel.Controls.Add(this.Search_btn);
            this.Tool_panel.Controls.Add(this.Filter_cbo);
            this.Tool_panel.Controls.Add(this.Search_txt);
            this.Tool_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tool_panel.Location = new System.Drawing.Point(10, 31);
            this.Tool_panel.Name = "Tool_panel";
            this.Tool_panel.Size = new System.Drawing.Size(1141, 63);
            this.Tool_panel.TabIndex = 2;
            // 
            // Remove_btn
            // 
            this.Remove_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Remove_btn.BackColor = System.Drawing.Color.Crimson;
            this.Remove_btn.BackgroundColor = System.Drawing.Color.Crimson;
            this.Remove_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Remove_btn.BorderRadius = 20;
            this.Remove_btn.BorderSize = 0;
            this.Remove_btn.FlatAppearance.BorderSize = 0;
            this.Remove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_btn.ForeColor = System.Drawing.Color.White;
            this.Remove_btn.Location = new System.Drawing.Point(272, 12);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(128, 37);
            this.Remove_btn.TabIndex = 19;
            this.Remove_btn.Text = "Remove";
            this.Remove_btn.TextColor = System.Drawing.Color.White;
            this.Remove_btn.UseVisualStyleBackColor = false;
            this.Remove_btn.Click += new System.EventHandler(this.Remove_btn_Click);
            // 
            // Edit_btn
            // 
            this.Edit_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Edit_btn.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.Edit_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Edit_btn.BorderRadius = 20;
            this.Edit_btn.BorderSize = 0;
            this.Edit_btn.FlatAppearance.BorderSize = 0;
            this.Edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_btn.ForeColor = System.Drawing.Color.White;
            this.Edit_btn.Location = new System.Drawing.Point(138, 12);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(128, 37);
            this.Edit_btn.TabIndex = 18;
            this.Edit_btn.Text = "Edit";
            this.Edit_btn.TextColor = System.Drawing.Color.White;
            this.Edit_btn.UseVisualStyleBackColor = false;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.Add_btn.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.Add_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Add_btn.BorderRadius = 20;
            this.Add_btn.BorderSize = 0;
            this.Add_btn.FlatAppearance.BorderSize = 0;
            this.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.Color.White;
            this.Add_btn.Location = new System.Drawing.Point(4, 12);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(128, 37);
            this.Add_btn.TabIndex = 17;
            this.Add_btn.Text = "Add";
            this.Add_btn.TextColor = System.Drawing.Color.White;
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Search_btn
            // 
            this.Search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Search_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Search_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Search_btn.BorderRadius = 20;
            this.Search_btn.BorderSize = 0;
            this.Search_btn.FlatAppearance.BorderSize = 0;
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.ForeColor = System.Drawing.Color.White;
            this.Search_btn.Location = new System.Drawing.Point(1009, 12);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(112, 37);
            this.Search_btn.TabIndex = 16;
            this.Search_btn.Text = "Search";
            this.Search_btn.TextColor = System.Drawing.Color.White;
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Filter_cbo
            // 
            this.Filter_cbo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Filter_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filter_cbo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter_cbo.FormattingEnabled = true;
            this.Filter_cbo.Items.AddRange(new object[] {
            "Name",
            "Unit",
            "Category"});
            this.Filter_cbo.Location = new System.Drawing.Point(575, 16);
            this.Filter_cbo.Name = "Filter_cbo";
            this.Filter_cbo.Size = new System.Drawing.Size(220, 33);
            this.Filter_cbo.TabIndex = 15;
            // 
            // Search_txt
            // 
            this.Search_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_txt.Location = new System.Drawing.Point(801, 15);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(189, 34);
            this.Search_txt.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1161, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QLProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLProduct";
            this.Size = new System.Drawing.Size(1161, 565);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Product_gridview)).EndInit();
            this.Tool_panel.ResumeLayout(false);
            this.Tool_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView Product_gridview;
        private System.Windows.Forms.Panel Tool_panel;
        private System.Windows.Forms.ComboBox Filter_cbo;
        private System.Windows.Forms.TextBox Search_txt;
        private MiniStore.Costumized.CostumButton Remove_btn;
        private MiniStore.Costumized.CostumButton Edit_btn;
        private MiniStore.Costumized.CostumButton Add_btn;
        private MiniStore.Costumized.CostumButton Search_btn;
    }
}
