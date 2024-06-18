using System;
using System.Windows.Forms;

namespace MiniStore.GUI.Items
{
    public partial class MyMessage : UserControl
    {
        public Form parent;
        public MyMessage(string message)
        {
            InitializeComponent();
            this.Message_label.Text = message;
        }
        internal MyMessage(string message, bool signal)
        {
            InitializeComponent();
            this.Message_label.Text = message;
            Message_picture.Image = global::MiniStore.Properties.Resources.successful;
        }
        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            parent.Close();
        }

    }
}
