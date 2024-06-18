using MiniStore.BUS;
using MiniStore.DTO;
using MiniStore.GUI.Items;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MiniStore.GUI.Controls
{
    public partial class EmployeeItem : UserControl
    {
        public Form parent;
        public int EditMode = 0;
        private string OldPassword;

        public EmployeeItem(int mode)
        {
            InitializeComponent();
            EditMode = mode;
            Role_cbo.Text = "Cashier";
            if (mode == 0) Role_cbo.Enabled = false;
            if (mode == 2) UserN_txt.Enabled = true;
        }
        public void initUser(EmployeeDTO user)
        {
            UserN_txt.Texts = user.ID;
            OldPassword = Passwd_txt.Texts = user.Pass;
            Name_txt.Texts = user.Name;
            Phone_txt.Texts = user.Phone;
            Role_cbo.Text = user.Role.ToString();
            Avatar.ImageLocation = user.Imgdir;

        }
        bool checkinput()
        {
            bool Verification = true;
            string message = "";
            string sdt = Phone_txt.Texts;
            long ketqua;


            if (!string.IsNullOrEmpty(Phone_txt.Texts) && (sdt.Length != 10 || !(new Regex(@"^[0-9]+$").IsMatch(sdt))))
            {
                message = "Invalid phone number";
                Phone_txt.Focus();
                Verification = false;
            }

            if (UserN_txt.Texts == "" || Passwd_txt.Texts == "" ||
                Name_txt.Texts == "")
            {
                message = "Some fields are blank";
                UserN_txt.Focus();
                Verification = false;
            }

            if (!Verification)
            {
                MessageDialog.Show(message);
            }
            return Verification;
        }
        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (!checkinput()) return;
            EmployeeDTO user = new EmployeeDTO(UserN_txt.Texts, Passwd_txt.Texts,
                Role_cbo.Text, Name_txt.Texts, Phone_txt.Texts, Avatar.ImageLocation);
            MyDialog dialog = new MyDialog();
            switch (EditMode)
            {
                case 0: //selft edit
                    PasswordEnter psswd = new PasswordEnter(OldPassword);
                    dialog.initMessage(psswd);
                    psswd.parent = dialog;
                    dialog.ShowDialog();
                    if (psswd.Verification)
                        if (EmployeeBUS.updateEmployee(user) > 0)
                        {
                            MessageDialog.Show("Save Changes Successfully", true);
                        }

                    break;
                case 1: //manager edit
                    if (EmployeeBUS.updateEmployee(user) > 0)
                    {
                        MessageDialog.Show("Save Changes Successfully", true);
                        this.Dispose();
                        parent.Close();
                    }
                    break;
                case 2: //create user
                    if (EmployeeBUS.addEmployee(user))
                    {
                        MessageDialog.Show("Add User Successfully", true);
                        this.Dispose();
                        parent.Close();
                    }
                    break;
            }
        }

        private void Image_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Image Files(*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png)|*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                this.Avatar.ImageLocation = open.FileName;
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            if (parent != null)
            {
                this.Dispose();
                parent.Close();
            }
        }

    }
}
