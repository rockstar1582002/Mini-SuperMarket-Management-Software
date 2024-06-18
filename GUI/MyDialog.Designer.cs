namespace MiniStore.GUI
{
    partial class MyDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.TaskBar = new System.Windows.Forms.FlowLayoutPanel();
            this.MessagePanel = new System.Windows.Forms.Panel();
            this.ButtonPanel.SuspendLayout();
            this.TaskBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.iconButton1);
            this.ButtonPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ButtonPanel.Location = new System.Drawing.Point(552, 0);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(128, 36);
            this.ButtonPanel.TabIndex = 5;
            this.ButtonPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPanel_MouseDown);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 19;
            this.iconButton1.Location = new System.Drawing.Point(89, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(36, 36);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // TaskBar
            // 
            this.TaskBar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.TaskBar.Controls.Add(this.ButtonPanel);
            this.TaskBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TaskBar.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.TaskBar.Location = new System.Drawing.Point(0, 0);
            this.TaskBar.Margin = new System.Windows.Forms.Padding(0);
            this.TaskBar.Name = "TaskBar";
            this.TaskBar.Size = new System.Drawing.Size(680, 36);
            this.TaskBar.TabIndex = 6;
            this.TaskBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskBar_MouseDown);
            // 
            // MessagePanel
            // 
            this.MessagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagePanel.Location = new System.Drawing.Point(0, 36);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(680, 317);
            this.MessagePanel.TabIndex = 7;
            // 
            // MyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 353);
            this.Controls.Add(this.MessagePanel);
            this.Controls.Add(this.TaskBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyDialog";
            this.ButtonPanel.ResumeLayout(false);
            this.TaskBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ButtonPanel;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.FlowLayoutPanel TaskBar;
        private System.Windows.Forms.Panel MessagePanel;
    }
}