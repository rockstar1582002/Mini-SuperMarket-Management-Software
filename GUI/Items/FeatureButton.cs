using System.Windows.Forms;

namespace MiniStore.GUI
{
    public class FeatureButton : FontAwesome.Sharp.IconPictureBox
    {
        public static MainScreen main { get; set; }
        public FeatureName Fname;
        public FeatureButton()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.Transparent;
            this.IconColor = System.Drawing.Color.White;
            this.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconSize = 300;
            this.Size = new System.Drawing.Size(105, 75);
            this.Margin = new Padding(0);
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FeatureButton
            // 
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FeatureButton_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        private void FeatureButton_MouseClick(object sender, MouseEventArgs e)
        {
            main.SwitchFeatureEvent(Fname);
        }
    }
}
