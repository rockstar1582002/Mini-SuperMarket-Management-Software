namespace MiniStore.GUI.Features
{
    partial class Invoices
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
            this.Invoice_gridview = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Input_grp = new System.Windows.Forms.GroupBox();
            this.Tool_panel = new System.Windows.Forms.Panel();
            this.Add_btn = new MiniStore.Costumized.CostumButton();
            this.label1 = new System.Windows.Forms.Label();
            this.date_2 = new System.Windows.Forms.DateTimePicker();
            this.date_1 = new System.Windows.Forms.DateTimePicker();
            this.Remove_btn = new MiniStore.Costumized.CostumButton();
            this.Edit_btn = new MiniStore.Costumized.CostumButton();
            this.Search_btn = new MiniStore.Costumized.CostumButton();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.Title_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Invoice_gridview)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Input_grp.SuspendLayout();
            this.Tool_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Invoice_gridview
            // 
            this.Invoice_gridview.AllowUserToAddRows = false;
            this.Invoice_gridview.AllowUserToDeleteRows = false;
            this.Invoice_gridview.AllowUserToOrderColumns = true;
            this.Invoice_gridview.AllowUserToResizeColumns = false;
            this.Invoice_gridview.AllowUserToResizeRows = false;
            this.Invoice_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Invoice_gridview.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Invoice_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Invoice_gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Invoice_gridview.Location = new System.Drawing.Point(11, 107);
            this.Invoice_gridview.Margin = new System.Windows.Forms.Padding(11);
            this.Invoice_gridview.Name = "Invoice_gridview";
            this.Invoice_gridview.ReadOnly = true;
            this.Invoice_gridview.RowHeadersVisible = false;
            this.Invoice_gridview.RowHeadersWidth = 51;
            this.Invoice_gridview.RowTemplate.Height = 24;
            this.Invoice_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Invoice_gridview.Size = new System.Drawing.Size(1263, 465);
            this.Invoice_gridview.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Title_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 649);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Input_grp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1285, 583);
            this.panel2.TabIndex = 4;
            // 
            // Input_grp
            // 
            this.Input_grp.Controls.Add(this.Invoice_gridview);
            this.Input_grp.Controls.Add(this.Tool_panel);
            this.Input_grp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Input_grp.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_grp.Location = new System.Drawing.Point(0, 0);
            this.Input_grp.Margin = new System.Windows.Forms.Padding(11);
            this.Input_grp.Name = "Input_grp";
            this.Input_grp.Padding = new System.Windows.Forms.Padding(11);
            this.Input_grp.Size = new System.Drawing.Size(1285, 583);
            this.Input_grp.TabIndex = 13;
            this.Input_grp.TabStop = false;
            this.Input_grp.Text = "Products";
            // 
            // Tool_panel
            // 
            this.Tool_panel.Controls.Add(this.Add_btn);
            this.Tool_panel.Controls.Add(this.label1);
            this.Tool_panel.Controls.Add(this.date_2);
            this.Tool_panel.Controls.Add(this.date_1);
            this.Tool_panel.Controls.Add(this.Remove_btn);
            this.Tool_panel.Controls.Add(this.Edit_btn);
            this.Tool_panel.Controls.Add(this.Search_btn);
            this.Tool_panel.Controls.Add(this.Search_txt);
            this.Tool_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tool_panel.Location = new System.Drawing.Point(11, 32);
            this.Tool_panel.Name = "Tool_panel";
            this.Tool_panel.Size = new System.Drawing.Size(1263, 75);
            this.Tool_panel.TabIndex = 2;
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
            this.Add_btn.Location = new System.Drawing.Point(18, 10);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(144, 44);
            this.Add_btn.TabIndex = 23;
            this.Add_btn.Text = "Add";
            this.Add_btn.TextColor = System.Drawing.Color.White;
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(751, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "to";
            // 
            // date_2
            // 
            this.date_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date_2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_2.Location = new System.Drawing.Point(789, 19);
            this.date_2.Name = "date_2";
            this.date_2.Size = new System.Drawing.Size(142, 34);
            this.date_2.TabIndex = 21;
            this.date_2.Value = new System.DateTime(2022, 12, 5, 0, 0, 0, 0);
            // 
            // date_1
            // 
            this.date_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date_1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_1.Location = new System.Drawing.Point(602, 19);
            this.date_1.Name = "date_1";
            this.date_1.Size = new System.Drawing.Size(142, 34);
            this.date_1.TabIndex = 20;
            this.date_1.Value = new System.DateTime(1911, 1, 1, 23, 29, 0, 0);
            // 
            // Remove_btn
            // 
            this.Remove_btn.BackColor = System.Drawing.Color.Crimson;
            this.Remove_btn.BackgroundColor = System.Drawing.Color.Crimson;
            this.Remove_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Remove_btn.BorderRadius = 20;
            this.Remove_btn.BorderSize = 0;
            this.Remove_btn.FlatAppearance.BorderSize = 0;
            this.Remove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_btn.ForeColor = System.Drawing.Color.White;
            this.Remove_btn.Location = new System.Drawing.Point(319, 10);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(144, 44);
            this.Remove_btn.TabIndex = 19;
            this.Remove_btn.Text = "Remove";
            this.Remove_btn.TextColor = System.Drawing.Color.White;
            this.Remove_btn.UseVisualStyleBackColor = false;
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
            this.Edit_btn.Location = new System.Drawing.Point(170, 10);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(144, 44);
            this.Edit_btn.TabIndex = 18;
            this.Edit_btn.Text = "Edit";
            this.Edit_btn.TextColor = System.Drawing.Color.White;
            this.Edit_btn.UseVisualStyleBackColor = false;
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
            this.Search_btn.Location = new System.Drawing.Point(1114, 10);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(126, 44);
            this.Search_btn.TabIndex = 16;
            this.Search_btn.Text = "Search";
            this.Search_btn.TextColor = System.Drawing.Color.White;
            this.Search_btn.UseVisualStyleBackColor = false;
            // 
            // Search_txt
            // 
            this.Search_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_txt.Location = new System.Drawing.Point(942, 18);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(164, 34);
            this.Search_txt.TabIndex = 13;
            // 
            // Title_label
            // 
            this.Title_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title_label.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Title_label.Location = new System.Drawing.Point(0, 0);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(1285, 66);
            this.Title_label.TabIndex = 3;
            this.Title_label.Text = "Invoice Management";
            this.Title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Invoices";
            this.Padding = new System.Windows.Forms.Padding(11);
            this.Size = new System.Drawing.Size(1307, 671);
            ((System.ComponentModel.ISupportInitialize)(this.Invoice_gridview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.Input_grp.ResumeLayout(false);
            this.Tool_panel.ResumeLayout(false);
            this.Tool_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Invoice_gridview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox Input_grp;
        private System.Windows.Forms.Panel Tool_panel;
        private Costumized.CostumButton Add_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_2;
        private System.Windows.Forms.DateTimePicker date_1;
        private Costumized.CostumButton Remove_btn;
        private Costumized.CostumButton Edit_btn;
        private Costumized.CostumButton Search_btn;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.Label Title_label;
    }
}
