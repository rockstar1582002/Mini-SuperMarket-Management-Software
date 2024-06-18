﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiniStore.Costumized
{
    public partial class CostumTextbox : UserControl
    {
        public event EventHandler TextChanged;
        private void HandleTextChanged(object sender, EventArgs e)
        {
            // we'll explain this in a minute
            this.OnTxtTextChanged(EventArgs.Empty);
        }

        protected virtual void OnTxtTextChanged(EventArgs e)
        {
            if (this.TextChanged != null)
            {
                this.TextChanged(this, e);
                textBox1.Select(textBox1.Text.Length, 0);
            }
        }

        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;
        public CostumTextbox()
        {
            InitializeComponent();
            textBox1.TextChanged += this.HandleTextChanged;
        }

        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; this.Invalidate(); }
        }
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; this.Invalidate(); }
        }
        public bool UnderlinedStyle
        {
            get => underlinedStyle;
            set { underlinedStyle = value; this.Invalidate(); }
        }

        public bool IsFocused
        {
            get => isFocused;
            set { isFocused = value; this.Invalidate(); }
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }
        public string Texts
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            //Draw border
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (isFocused) penBorder.Color = borderFocusColor;//Set Border color in focus. Otherwise, normal border color
                if (underlinedStyle) //Line Style
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else //Normal Style
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }


    }

}
