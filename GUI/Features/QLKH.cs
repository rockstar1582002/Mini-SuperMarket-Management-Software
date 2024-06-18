using MiniStore.BUS;
using MiniStore.DTO;
using MiniStore.GUI.Features;
using MiniStore.GUI.Items;
using System;
using System.Windows.Forms;

namespace QLKH_QLNV
{
    public partial class QLKH : UserControl
    {

        public QLKH()
        {
            InitializeComponent();
            QLKH_Load();
        }

        private void QLKH_Load()
        {
            comboBox1.Text = "Số điện thoại";
            try
            {
                dataGridView1.DataSource = ConsumerBUS.getAllConsumer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //bool checkinput()
        //{
        //    //string sdt = txtsdt.Text;
        //    //long ketqua;
        //    //char[] mangsdt = sdt.ToCharArray();
        //    //if (txtsdt.Text == "" || txtname.Text == "")
        //    //{
        //    //    MessageBox.Show("Yêu cầu nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    //    txtsdt.Focus();
        //    //    return false;
        //    //}
        //    //if (!(long.TryParse(sdt, out ketqua)))
        //    //{
        //    //    MessageBox.Show("Hãy nhập đúng định dạng số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    //    txtsdt.Focus();
        //    //    return false;
        //    //}
        //    //if (ketqua < 0)
        //    //{
        //    //    MessageBox.Show("Số điện thoại không được âm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    //    txtsdt.Focus();
        //    //    return false;
        //    //}
        //    //if (mangsdt.Length != 10)
        //    //{
        //    //    MessageBox.Show("Số điện thoại phải đúng 10 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    //    txtsdt.Focus();
        //    //    return false;
        //    //}
        //    return true;
        //}
        private void btnthem_Click(object sender, EventArgs e)
        {
            //if (checkinput())
            //{
            //string phone = txtsdt.Text;
            //string name = txtname.Text;
            //string point = txtdiem.Text;
            //string birth = birthday.Text;
            //dto = new ConsumerDTO(phone, name, birth);
            //if (bus.addConsumer(dto))
            //{
            //    dataGridView1.DataSource = bus.getAllConsumer();
            //}
            //else
            //{
            //    MyMessage message = new MyMessage("The phone number is already existed!!!");
            //    MyDialog dialog = new MyDialog(message);
            //    message.parent = dialog;
            //    dialog.ShowDialog();
            //}

            //kh = new Khachhang(phone, name, point, birth, avai);
            //if (modify.AddKhachhang(kh))
            //{
            //    dataGridView1.DataSource = modify.getAllKhachHang();
            //}
            //else
            //{
            //    MessageBox.Show("Thêm không thành công do dữ liệu bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //}
            ConsumerSetting.Show();
            dataGridView1.DataSource = ConsumerBUS.getAllConsumer();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            //if (checkinput())
            //{
            //    //string phone = txtsdt.Text;
            //    //string name = txtname.Text;
            //    //string point = txtdiem.Text;
            //    //string birth = birthday.Text;
            //    //kh = new Khachhang(phone, name, point, birth, avai);
            //    //if (modify.editKhachhang(kh))
            //    //{
            //    //    dataGridView1.DataSource = modify.getAllKhachHang();
            //    //}
            //}
            if (dataGridView1.SelectedRows.Count == 0)
            {
                ConfirmDialog.Show("Please choose a Consumer to remove");
                return;
            }
            ConsumerSetting.Show(
                new ConsumerDTO(
                    dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                    dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                    int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()),
                    dataGridView1.SelectedRows[0].Cells[3].Value.ToString()
                    )
                );

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                ConfirmDialog.Show("Please choose a Consumer to remove");
                return;
            }
            ConfirmDialog.Show("Remove this Consumer?");
            if (ConfirmDialog.Confirm.Confimation)
            {
                ConsumerBUS.removeConsumer(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                dataGridView1.DataSource = ConsumerBUS.getAllConsumer();
            }


            //DialogResult result = MessageBox.Show("Bạn có muốn xóa không? Dữ liệu sẽ không được khôi phục", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (result == DialogResult.Yes)
            //{
            //    //string phone = txtsdt.Text;
            //    //string name = txtname.Text;
            //    //string point = txtdiem.Text;
            //    //string birth = birthday.Text;
            //    //kh = new Khachhang(phone, name, point, birth, avai);
            //    //if (modify.DelKhachhang(kh))
            //    //{
            //    //    dataGridView1.DataSource = modify.getAllKhachHang();
            //    //}
            //}          
        }
        private void btnfind_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Số điện thoại")
            {
                dataGridView1.DataSource = ConsumerBUS.seachAdvance("phone", txtfind.Text);
            }
            if (comboBox1.Text == "Họ tên khách hàng")
            {
                dataGridView1.DataSource = ConsumerBUS.seachAdvance("name", txtfind.Text);

            }

            ////private void txtfind_TextChanged(object sender, EventArgs e)
            //{
            //    //if (comboBox1.Text == "Số điện thoại")
            //    //{
            //    //    dataGridView2.DataSource = modify.HienDuLieu("select phone, name, points, birthday from Consumer where phone like '%" + txtfind.Text.Trim() + "%' ");
            //    //}
            //    //if (comboBox1.Text == "Họ tên khách hàng")
            //    //{
            //    //    dataGridView2.DataSource = modify.HienDuLieu("select phone, name, points, birthday from Consumer where name like '%" + txtfind.Text.Trim() + "%' ");
            //    //}
            //}

            ////private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            //{
            //    if (dataGridView1.SelectedRows.Count >= 0)
            //    {
            //        //txtsdt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //        //txtname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //        //txtdiem.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            //        //birthday.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            //    }
        }

    }
}
