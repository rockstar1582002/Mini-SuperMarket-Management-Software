using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiniStore.GUI
{
    public enum FeatureName
    {
        Cashier,
        Inventory,
        Management,
        
        Statistic,
        Setting,
        Help
    }
    public partial class FeatureIcon : UserControl
    {
        public static MainScreen main;
        public FeatureName Fname = GUI.FeatureName.Cashier;
        public FeatureIcon()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        public void setIcon(FontAwesome.Sharp.IconChar icon)
        {
            this.FeaturePic.IconChar = icon;
        }
        public void setFeatureName(string name)
        {
            this.FeatureName.Text = name;
        }
        private Color oldBottom;
        private Color oldTop;
        private void MouseEntered()
        {
            oldBottom = this.gPanel1.GradientBottomColor;
            oldTop = this.gPanel1.GradientTopColor;
            this.gPanel1.GradientBottomColor = System.Drawing.Color.SlateBlue;
            this.gPanel1.GradientTopColor = System.Drawing.Color.MediumBlue;
        }

        private void MouseLeaved()
        {
            this.gPanel1.GradientBottomColor = oldBottom;
            this.gPanel1.GradientTopColor = oldTop;
        }

        private void FeaturePic_MouseEnter(object sender, EventArgs e)
        {
            MouseEntered();
        }

        private void FeaturePic_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaved();
        }

        private void FeatureName_MouseEnter(object sender, EventArgs e)
        {
            MouseEntered();
        }

        private void FeatureName_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaved();
        }

        private void FeatureName_Click(object sender, EventArgs e)
        {
            main.SwitchScreenEvent(true);
            main.SwitchFeatureEvent(Fname);
        }

        private void FeaturePic_Click(object sender, EventArgs e)
        {
            main.SwitchScreenEvent(true);
            main.SwitchFeatureEvent(Fname);
        }
    }
}
