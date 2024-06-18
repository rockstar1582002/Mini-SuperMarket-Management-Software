namespace MiniStore.GUI.Items
{
    partial class Confirmation
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
            this.Message_label = new System.Windows.Forms.Label();
            this.Confirm_btn = new MiniStore.Costumized.CostumButton();
            this.Cancel_btn = new MiniStore.Costumized.CostumButton();
            this.Message_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Message_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Message_label
            // 
            this.Message_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message_label.Location = new System.Drawing.Point(85, 129);
            this.Message_label.Name = "Message_label";
            this.Message_label.Size = new System.Drawing.Size(318, 79);
            this.Message_label.TabIndex = 5;
            this.Message_label.Text = "Message";
            this.Message_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Confirm_btn.Location = new System.Drawing.Point(276, 211);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(108, 46);
            this.Confirm_btn.TabIndex = 3;
            this.Confirm_btn.Text = "Yes";
            this.Confirm_btn.TextColor = System.Drawing.Color.White;
            this.Confirm_btn.UseVisualStyleBackColor = false;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
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
            this.Cancel_btn.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_btn.ForeColor = System.Drawing.Color.White;
            this.Cancel_btn.Location = new System.Drawing.Point(106, 211);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(108, 46);
            this.Cancel_btn.TabIndex = 6;
            this.Cancel_btn.Text = "No";
            this.Cancel_btn.TextColor = System.Drawing.Color.White;
            this.Cancel_btn.UseVisualStyleBackColor = false;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Message_picture
            // 
            this.Message_picture.BackColor = System.Drawing.Color.Transparent;
            this.Message_picture.Image = global::MiniStore.Properties.Resources.confirm;
            this.Message_picture.Location = new System.Drawing.Point(187, 6);
            this.Message_picture.Name = "Message_picture";
            this.Message_picture.Size = new System.Drawing.Size(123, 120);
            this.Message_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Message_picture.TabIndex = 4;
            this.Message_picture.TabStop = false;
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Message_label);
            this.Controls.Add(this.Message_picture);
            this.Controls.Add(this.Confirm_btn);
            this.Name = "Confirmation";
            this.Size = new System.Drawing.Size(488, 299);
            ((System.ComponentModel.ISupportInitialize)(this.Message_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Message_label;
        private System.Windows.Forms.PictureBox Message_picture;
        private Costumized.CostumButton Confirm_btn;
        private Costumized.CostumButton Cancel_btn;
    }
}
