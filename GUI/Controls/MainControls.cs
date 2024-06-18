using MiniStore.GUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MiniStore
{
    public partial class MainControl : UserControl
    {
        private MainScreen parent;
        private List<FeatureButton> features;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        public MainControl(MainScreen parent)
        {
            InitializeComponent();
            this.parent = parent;

        }
        public void init(string avatar)
        {
            this.avatar.ImageLocation = avatar;
        }
        public void SwitchFeature(UserControl featureControl, FeatureName Fname)
        {
            foreach (FeatureButton button in features)
            {
                if (button.Fname == Fname)
                {
                    button.BackColor = Color.DarkSlateBlue;
                    continue;
                }
                button.BackColor = Color.Transparent;
            }

            this.FeaturePanel.Controls.Clear();
            featureControl.Dock = DockStyle.Fill;
            this.FeaturePanel.Controls.Add(featureControl);
        }

        public void AddFeatures(List<FeatureButton> features)
        {
            this.features = features;
            foreach (FeatureButton feature in features)
            {
                this.LeftPanel.Controls.Add(feature);
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            parent.SwitchScreenEvent(false);
        }

    }
}
