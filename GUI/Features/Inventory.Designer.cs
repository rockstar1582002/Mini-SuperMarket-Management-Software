namespace MiniStore.GUI.Features
{
    partial class Inventory
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
            this.Inventory_tab = new System.Windows.Forms.TabControl();
            this.ProductMng_tab = new System.Windows.Forms.TabPage();
            this.Product = new Kho.QLProduct();
            this.InputMng_tab = new System.Windows.Forms.TabPage();
            this.InputMng = new MiniStore.GUI.Items.InputMng(Employee);
            this.Inventory_tab.SuspendLayout();
            this.ProductMng_tab.SuspendLayout();
            this.InputMng_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Inventory_tab
            // 
            this.Inventory_tab.Controls.Add(this.ProductMng_tab);
            this.Inventory_tab.Controls.Add(this.InputMng_tab);
            this.Inventory_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inventory_tab.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory_tab.Location = new System.Drawing.Point(0, 0);
            this.Inventory_tab.Name = "Inventory_tab";
            this.Inventory_tab.SelectedIndex = 0;
            this.Inventory_tab.Size = new System.Drawing.Size(1161, 565);
            this.Inventory_tab.TabIndex = 0;
            this.Inventory_tab.SelectedIndexChanged += new System.EventHandler(this.Inventory_tab_SelectedIndexChanged);
            // 
            // ProductMng_tab
            // 
            this.ProductMng_tab.Controls.Add(this.Product);
            this.ProductMng_tab.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductMng_tab.Location = new System.Drawing.Point(4, 38);
            this.ProductMng_tab.Margin = new System.Windows.Forms.Padding(0);
            this.ProductMng_tab.Name = "ProductMng_tab";
            this.ProductMng_tab.Size = new System.Drawing.Size(1153, 523);
            this.ProductMng_tab.TabIndex = 0;
            this.ProductMng_tab.Text = "Product";
            this.ProductMng_tab.UseVisualStyleBackColor = true;
            // 
            // Product
            // 
            this.Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Product.Location = new System.Drawing.Point(0, 0);
            this.Product.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(1153, 523);
            this.Product.TabIndex = 0;
            // 
            // InputMng_tab
            // 
            this.InputMng_tab.Controls.Add(this.InputMng);
            this.InputMng_tab.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputMng_tab.Location = new System.Drawing.Point(4, 38);
            this.InputMng_tab.Margin = new System.Windows.Forms.Padding(0);
            this.InputMng_tab.Name = "InputMng_tab";
            this.InputMng_tab.Size = new System.Drawing.Size(1153, 523);
            this.InputMng_tab.TabIndex = 2;
            this.InputMng_tab.Text = "Input";
            this.InputMng_tab.UseVisualStyleBackColor = true;
            // 
            // InputMng
            // 
            this.InputMng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputMng.Location = new System.Drawing.Point(0, 0);
            this.InputMng.Margin = new System.Windows.Forms.Padding(4);
            this.InputMng.Name = "InputMng";
            this.InputMng.Size = new System.Drawing.Size(1153, 523);
            this.InputMng.TabIndex = 0;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.Inventory_tab);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(1161, 565);
            this.Inventory_tab.ResumeLayout(false);
            this.ProductMng_tab.ResumeLayout(false);
            this.InputMng_tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Inventory_tab;
        private System.Windows.Forms.TabPage ProductMng_tab;
        private Kho.QLProduct Product;
        private System.Windows.Forms.TabPage InputMng_tab;
        private Items.InputMng InputMng;
    }
}
