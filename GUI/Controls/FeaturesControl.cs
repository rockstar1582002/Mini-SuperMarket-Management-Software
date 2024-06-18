using System.Collections.Generic;
using System.Windows.Forms;

namespace MiniStore.GUI
{
    public partial class FeaturesControl : UserControl
    {
        public FeaturesControl()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        public void AddFeatures(List<FeatureIcon> features)
        {
            foreach (FeatureIcon feature in features)
            {
                this.FlowFeatures.Controls.Add(feature);
            }
        }
        public void init(string name, string avatar)
        {
            this.UserN_label.Text = name;
            this.Avatar.ImageLocation = avatar;
        }

    }
}
