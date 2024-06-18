using MiniStore.BUS;
using MiniStore.DTO;
using MiniStore.GUI.Features;
using MiniStore.GUI.Items;
using System;
using System.Windows.Forms;

namespace QLKH_QLNV
{
    public partial class QLNV : UserControl
    {
        public QLNV()
        {
            InitializeComponent();
            QLNV_Load();
        }

        private void QLNV_Load()
        {
            comboBox1.Text = "Mã nhân viên";
            try
            {
                dataGridView2.DataSource = EmployeeBUS.getAllEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //bool checkinput()
        //{
        //    string sdt = txtsdt.Text;
        //    long ketqua;
        //    char[] mangsdt = sdt.ToCharArray();
        //    if(txtID.Text == "" || txtsdt.Text == "" || txtName.Text == "" || txtPass.Text == "" || cbrole.Text == "")
        //    {
        //        MessageBox.Show("Yêu cầu nhập đầy đủ thông tin","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        //        txtID.Focus();
        //        return false;
        //    }
        //    if(!(long.TryParse(sdt, out ketqua)))
        //    {
        //        MessageBox.Show("Hãy nhập đúng định dạng số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtsdt.Focus();
        //        return false;
        //    }
        //    if (ketqua < 0)
        //    {
        //        MessageBox.Show("Số điện thoại không được âm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtsdt.Focus();
        //        return false;
        //    }
        //    if(mangsdt.Length != 10)
        //    {
        //        MessageBox.Show("Số điện thoại phải đúng 10 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtsdt.Focus();
        //        return false;
        //    }
        //    return true;
        //}

        private void btnthem_Click(object sender, EventArgs e)
        {
            //if (checkinput())
            //{
            //    string id = txtID.Text;
            //    string pass = txtPass.Text;
            //    string role = cbrole.Text;
            //    string name = txtName.Text;
            //    string phone = txtsdt.Text;
            //    string img = label8.Text;

            //    EmployeeDTO employee = new EmployeeDTO(id, pass, role, name, phone, img);
            //    if (bus.addEmployee(employee))
            //    {
            //        dataGridView1.DataSource = bus.getAllEmployee();
            //        MessageBox.Show("Thêm thành công");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Thêm không thành công do dữ liệu bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            EmployeeSetting.Show(2);
            QLNV_Load();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            //if (checkinput())
            //{
            //    string id = txtID.Text;
            //    string pass = txtPass.Text;
            //    string role = cbrole.Text;
            //    string name = txtName.Text;
            //    string phone = txtsdt.Text;
            //    string img = label8.Text;

            //    EmployeeDTO employee = new EmployeeDTO(id, pass, role, name, phone, img);
            //    if (bus.updateEmployee(employee) != 0)
            //    {
            //        dataGridView1.DataSource = bus.getAllEmployee();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Sửa không thành công kiểm tra lại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageDialog.Show("Choose a User to Modify");
                return;
            }

            EmployeeSetting.Show(1, new EmployeeDTO(
                dataGridView2.SelectedRows[0].Cells[0].Value.ToString(),
                dataGridView2.SelectedRows[0].Cells[1].Value.ToString(),
                dataGridView2.SelectedRows[0].Cells[2].Value.ToString(),
                dataGridView2.SelectedRows[0].Cells[3].Value.ToString(),
                dataGridView2.SelectedRows[0].Cells[4].Value.ToString(),
                dataGridView2.SelectedRows[0].Cells[5].Value.ToString()
                ));
            QLNV_Load();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageDialog.Show("Choose a User to Remove");
                return;
            }
            string ID = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            ConfirmDialog.Show($"Remove User {ID}? ");
            if (ConfirmDialog.Confirm.Confimation)
            {
                if (EmployeeBUS.removeEmployee(ID) != 0)
                {
                    MessageDialog.Show("Remove User Successfull", true);
                    dataGridView2.DataSource = EmployeeBUS.getAllEmployee();
                }
                else
                {
                    MessageDialog.Show("Remove User Unsuccessfull");
                }
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Phone Number":
                    dataGridView2.DataSource = EmployeeBUS.searchAdvance("phone", txtfind.Text.Trim());
                    break;
                case "Name":
                    dataGridView2.DataSource = EmployeeBUS.searchAdvance("name", txtfind.Text.Trim());
                    break;
                default:
                    dataGridView2.DataSource = EmployeeBUS.searchAdvance("id", txtfind.Text.Trim());
                    break;
            }
        }


    }
}
