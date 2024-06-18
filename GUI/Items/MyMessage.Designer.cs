namespace MiniStore.GUI.Items
{
    partial class MyMessage
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
            this.Confirm_btn = new MiniStore.Costumized.CostumButton();
            this.Message_label = new System.Windows.Forms.Label();
            this.Message_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Message_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Confirm_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Confirm_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Confirm_btn.BorderRadius = 20;
            this.Confirm_btn.BorderSize = 0;
            this.Confirm_btn.FlatAppearance.BorderSize = 0;
            this.Confirm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm_btn.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_btn.ForeColor = System.Drawing.Color.White;
            this.Confirm_btn.Location = new System.Drawing.Point(168, 212);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(150, 46);
            this.Confirm_btn.TabIndex = 0;
            this.Confirm_btn.Text = "OK";
            this.Confirm_btn.TextColor = System.Drawing.Color.White;
            this.Confirm_btn.UseVisualStyleBackColor = false;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // Message_label
            // 
            this.Message_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message_label.Location = new System.Drawing.Point(78, 130);
            this.Message_label.Name = "Message_label";
            this.Message_label.Size = new System.Drawing.Size(318, 79);
            this.Message_label.TabIndex = 2;
            this.Message_label.Text = "Message";
            this.Message_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Message_picture
            // 
            this.Message_picture.BackColor = System.Drawing.Color.Transparent;
            this.Message_picture.Image = global::MiniStore.Properties.Resources.confused;
            this.Message_picture.Location = new System.Drawing.Point(180, 7);
            this.Message_picture.Name = "Message_picture";
            this.Message_picture.Size = new System.Drawing.Size(123, 120);
            this.Message_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Message_picture.TabIndex = 1;
            this.Message_picture.TabStop = false;
            // 
            // MyMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Message_label);
            this.Controls.Add(this.Message_picture);
            this.Controls.Add(this.Confirm_btn);
            this.Name = "MyMessage";
            this.Size = new System.Drawing.Size(488, 299);
            ((System.ComponentModel.ISupportInitialize)(this.Message_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Costumized.CostumButton Confirm_btn;
        private System.Windows.Forms.PictureBox Message_picture;
        private System.Windows.Forms.Label Message_label;
    }
}
