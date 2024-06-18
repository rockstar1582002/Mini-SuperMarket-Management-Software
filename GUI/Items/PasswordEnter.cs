using System;
using System.Windows.Forms;

namespace MiniStore.GUI.Items
{
    public partial class PasswordEnter : UserControl
    {
        public Form parent;
        private string Password { get; }
        public bool Verification = false;
        public PasswordEnter(string password)
        {
            InitializeComponent();
            this.Password = password;
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            if (Passwd_txt.Texts == Password)
            {
                Verification = true;
                parent.Dispose();
                return;
            }
            MyMessage message = new MyMessage("Password is incorrect!!!");
            MyDialog dialog = new MyDialog(message);
            message.parent = dialog;
            dialog.ShowDialog();

        }
    }
}
