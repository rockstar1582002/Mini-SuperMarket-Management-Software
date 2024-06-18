namespace MiniStore.GUI.Features
{
    partial class Management
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
            this.Manager_tab = new System.Windows.Forms.TabControl();
            this.Employee_tab = new System.Windows.Forms.TabPage();
            this.Employee = new QLKH_QLNV.QLNV();
            this.Consumer = new System.Windows.Forms.TabPage();
            this.qlkh1 = new QLKH_QLNV.QLKH();
            this.Discount = new System.Windows.Forms.TabPage();
            this.khuyenmai1 = new khuyenmai.khuyenmai();
            this.Provider = new System.Windows.Forms.TabPage();
            this.qlProvider1 = new MiniStore.GUI.Features.QLProvider();
            this.Manager_tab.SuspendLayout();
            this.Employee_tab.SuspendLayout();
            this.Consumer.SuspendLayout();
            this.Discount.SuspendLayout();
            this.Provider.SuspendLayout();
            this.SuspendLayout();
            // 
            // Manager_tab
            // 
            this.Manager_tab.Controls.Add(this.Employee_tab);
            this.Manager_tab.Controls.Add(this.Consumer);
            this.Manager_tab.Controls.Add(this.Discount);
            this.Manager_tab.Controls.Add(this.Provider);
            this.Manager_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Manager_tab.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manager_tab.Location = new System.Drawing.Point(0, 0);
            this.Manager_tab.Name = "Manager_tab";
            this.Manager_tab.SelectedIndex = 0;
            this.Manager_tab.Size = new System.Drawing.Size(1161, 565);
            this.Manager_tab.TabIndex = 0;
            // 
            // Employee_tab
            // 
            this.Employee_tab.Controls.Add(this.Employee);
            this.Employee_tab.Location = new System.Drawing.Point(4, 38);
            this.Employee_tab.Name = "Employee_tab";
            this.Employee_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Employee_tab.Size = new System.Drawing.Size(1153, 523);
            this.Employee_tab.TabIndex = 0;
            this.Employee_tab.Text = "Employee";
            this.Employee_tab.UseVisualStyleBackColor = true;
            // 
            // Employee
            // 
            this.Employee.AutoSize = true;
            this.Employee.BackColor = System.Drawing.Color.White;
            this.Employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Employee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee.Location = new System.Drawing.Point(3, 3);
            this.Employee.Margin = new System.Windows.Forms.Padding(4);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(1147, 517);
            this.Employee.TabIndex = 0;
            // 
            // Consumer
            // 
            this.Consumer.Controls.Add(this.qlkh1);
            this.Consumer.Location = new System.Drawing.Point(4, 38);
            this.Consumer.Name = "Consumer";
            this.Consumer.Padding = new System.Windows.Forms.Padding(3);
            this.Consumer.Size = new System.Drawing.Size(1153, 523);
            this.Consumer.TabIndex = 1;
            this.Consumer.Text = "Consumer";
            this.Consumer.UseVisualStyleBackColor = true;
            // 
            // qlkh1
            // 
            this.qlkh1.BackColor = System.Drawing.Color.White;
            this.qlkh1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qlkh1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlkh1.Location = new System.Drawing.Point(3, 3);
            this.qlkh1.Margin = new System.Windows.Forms.Padding(5);
            this.qlkh1.Name = "qlkh1";
            this.qlkh1.Size = new System.Drawing.Size(1147, 517);
            this.qlkh1.TabIndex = 0;
            // 
            // Discount
            // 
            this.Discount.Controls.Add(this.khuyenmai1);
            this.Discount.Location = new System.Drawing.Point(4, 38);
            this.Discount.Name = "Discount";
            this.Discount.Padding = new System.Windows.Forms.Padding(3);
            this.Discount.Size = new System.Drawing.Size(1153, 523);
            this.Discount.TabIndex = 2;
            this.Discount.Text = "Discount";
            this.Discount.UseVisualStyleBackColor = true;
            // 
            // khuyenmai1
            // 
            this.khuyenmai1.BackColor = System.Drawing.Color.White;
            this.khuyenmai1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khuyenmai1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khuyenmai1.Location = new System.Drawing.Point(3, 3);
            this.khuyenmai1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.khuyenmai1.Name = "khuyenmai1";
            this.khuyenmai1.Size = new System.Drawing.Size(1147, 517);
            this.khuyenmai1.TabIndex = 0;
            // 
            // Provider
            // 
            this.Provider.Controls.Add(this.qlProvider1);
            this.Provider.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Provider.Location = new System.Drawing.Point(4, 38);
            this.Provider.Name = "Provider";
            this.Provider.Padding = new System.Windows.Forms.Padding(3);
            this.Provider.Size = new System.Drawing.Size(1153, 523);
            this.Provider.TabIndex = 3;
            this.Provider.Text = "Provider";
            this.Provider.UseVisualStyleBackColor = true;
            // 
            // qlProvider1
            // 
            this.qlProvider1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qlProvider1.Location = new System.Drawing.Point(3, 3);
            this.qlProvider1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.qlProvider1.Name = "qlProvider1";
            this.qlProvider1.Size = new System.Drawing.Size(1147, 517);
            this.qlProvider1.TabIndex = 0;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.Manager_tab);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Management";
            this.Size = new System.Drawing.Size(1161, 565);
            this.Manager_tab.ResumeLayout(false);
            this.Employee_tab.ResumeLayout(false);
            this.Employee_tab.PerformLayout();
            this.Consumer.ResumeLayout(false);
            this.Discount.ResumeLayout(false);
            this.Provider.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Manager_tab;
        private System.Windows.Forms.TabPage Employee_tab;
        private System.Windows.Forms.TabPage Consumer;
        private QLKH_QLNV.QLNV Employee;
        private QLKH_QLNV.QLKH qlkh1;
        private System.Windows.Forms.TabPage Discount;
        private khuyenmai.khuyenmai khuyenmai1;
        private System.Windows.Forms.TabPage Provider;
        private QLProvider qlProvider1;
    }
}
