
using MiniStore.BUS;
using MiniStore.DTO;
using MiniStore.GUI.Features;
using MiniStore.GUI.Items;
using System;
using System.Windows.Forms;

namespace Kho
{
    public partial class QLProduct : UserControl
    {
        //Modify modify;
        //SanPham sp;

        public QLProduct()
        {
            InitializeComponent();
            Filter_cbo.Text = "Name";
            load_data();
        }

        public void load_data()
        {
            Product_gridview.DataSource = ProductBUS.getAllProduct();
        }
        private void editProduct()
        {
            if (Product_gridview.SelectedRows.Count < 1) return;
            DataGridViewRow row = Product_gridview.SelectedRows[0];
            ProductDTO product = new ProductDTO(
                    row.Cells[0].Value.ToString(),
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    int.Parse(row.Cells[3].Value.ToString()),
                    row.Cells[4].Value.ToString(),
                    int.Parse(row.Cells[5].Value.ToString()),
                    row.Cells[6].Value.ToString(),
                    row.Cells[7].Value.ToString(),
                    row.Cells[8].Value.ToString()
                );
            ProductSetting.Show(product);
            load_data();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            ProductSetting.Show();
            load_data();

        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (Product_gridview.SelectedRows.Count < 1)
            {
                MessageDialog.Show("Choose product to Edit!!!");
            }
            editProduct();
        }

        private void Remove_btn_Click(object sender, EventArgs e)
        {
            if (Product_gridview.SelectedRows.Count < 1)
            {
                MessageDialog.Show("Choose products to remove!!!");
                return;
            }
            ConfirmDialog.Show("Do you want to remove these product?");
            if (!ConfirmDialog.Confirm.Confimation) return;
            foreach (DataGridViewRow row in Product_gridview.SelectedRows)
                ProductBUS.removeProduct(row.Cells[0].Value.ToString());
            load_data();
        }

        private void Product_gridview_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            editProduct();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            Product_gridview.DataSource = ProductBUS.searchAdvance(Filter_cbo.Text, Search_txt.Text);
        }



        //private void QLProduct_Load(object sender, EventArgs e)
        //{
        //    comboBox1.Text = "Mã sản phẩm";
        //    //modify = new Modify();
        //    //try
        //    //{
        //    //    dataGridView1.DataSource = modify.getAllSanpham();
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    MessageBox.Show(ex.Message);
        //    //}
        //}
        //private void auto()
        //{
        //    txtProductID.Text = "P-" + GetUniqueKey(6);
        //}

        //private void Reset()
        //{
        //    txtProductName.Text = "";
        //    cmbCategory.Text = "";
        //    txtPrice.Text = "";
        //    txtProvider.Text = "";
        //    txtQuantity.Text = "";
        //    btnxoa.Enabled = false;
        //    btnsua.Enabled = false;
        //    btnthem.Enabled = true;
        //    txtProductName.Focus();
        //}

        //public static string GetUniqueKey(int maxSize)
        //{
        //    char[] chars = new char[62];
        //    chars = "123456789".ToCharArray();
        //    byte[] data = new byte[1];
        //    RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
        //    crypto.GetNonZeroBytes(data);
        //    data = new byte[maxSize];
        //    crypto.GetNonZeroBytes(data);
        //    StringBuilder result = new StringBuilder(maxSize);
        //    foreach (byte b in data)
        //    {
        //        result.Append(chars[b % (chars.Length)]);
        //    }
        //    return result.ToString();
        //}

        //bool checkinput()
        //{
        //    if (txtProductName.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập tên sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        txtProductName.Focus();
        //        return false;
        //    }
        //    if (cmbCategory.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập loại sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        cmbCategory.Focus();
        //        return false;
        //    }
        //    if (txtPrice.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập giá", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        txtPrice.Focus();
        //        return false;
        //    }
        //    return true;
        //}

        //private void btnthem_Click(object sender, EventArgs e)
        //{

        //    if (checkinput())
        //    {
        //        auto();
        //        string id = txtProductID.Text;
        //        string name = txtProductName.Text;
        //        string category = cmbCategory.Text;
        //        int quantity = 0;
        //        int price = Int32.Parse(txtPrice.Text);
        //        string provider = txtProvider.Text;
        //        string img = label8.Text;
        //        //sp = new SanPham(id, name, quantity, price, provider, category, img, available);
        //        //if (modify.AddSanPham(sp))
        //        //{
        //        //    dataGridView1.DataSource = modify.getAllSanpham();
        //        //}
        //        btnthem.Enabled = false;
        //    }

        //    /*catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }*/
        //}


        //private void btnxoa_Click(object sender, EventArgs e)
        //{
        //    DialogResult result = MessageBox.Show("Bạn có muốn xóa không? Dữ liệu sẽ không được khôi phục", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //    if (result == DialogResult.Yes)
        //    {
        //        string id = txtProductID.Text;
        //        string name = txtProductName.Text;
        //        string category = cmbCategory.Text;
        //        int quantity = 0;
        //        int price = Int32.Parse(txtPrice.Text);
        //        string provider = txtProvider.Text;
        //        string img = label8.Text;
        //        //sp = new SanPham(id, name, quantity, price, provider, category, img, available);
        //        //if (modify.DelSanPham(sp))
        //        //{
        //        //    dataGridView1.DataSource = modify.getAllSanpham();
        //        //}
        //    }
        //}

        //private void btnsua_Click(object sender, EventArgs e)
        //{
        //    if (checkinput())
        //    {
        //        string id = txtProductID.Text;
        //        string name = txtProductName.Text;
        //        string category = cmbCategory.Text;
        //        int quantity = Int32.Parse(txtQuantity.Text);
        //        int price = Int32.Parse(txtPrice.Text);
        //        string provider = txtProvider.Text;
        //        string img = label8.Text;
        //        //sp = new SanPham(id, name, quantity, price, provider, category, img, available);
        //        //if (modify.editSanPham(sp))
        //        //{
        //        //    dataGridView1.DataSource = modify.getAllSanpham();
        //        //}
        //        //else
        //        //{
        //        //    MessageBox.Show("Sửa không thành công kiểm tra lại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        //}
        //    }
        //}

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dataGridView1.SelectedRows.Count >= 0)
        //    {
        //        txtProductID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        //        txtProductName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        //        cmbCategory.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        //        txtQuantity.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        //        txtProvider.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        //        label8.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        //    }
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Reset();
        //}

        //private void btnfind_Click(object sender, EventArgs e)
        //{
        //    //if (comboBox1.Text == "Mã sản phẩm")
        //    //{
        //    //    dataGridView2.DataSource = modify.HienDuLieu("select id, name, quantiry, category, price, provider, imgdir from Product where id like '%" + txtfind.Text.Trim() + "%' ");
        //    //}
        //    //if (comboBox1.Text == "Tên sản phẩm")
        //    //{
        //    //    dataGridView2.DataSource = modify.HienDuLieu("select id, name, quantiry, category, price, provider, imgdir from Product where id like '%" + txtfind.Text.Trim() + "%' ");
        //    //}
        //    //if (comboBox1.Text == "Loại sản phẩm")
        //    //{
        //    //    dataGridView2.DataSource = modify.HienDuLieu("select id, name, quantiry, category, price, provider, imgdir from Product where id like '%" + txtfind.Text.Trim() + "%' ");
        //    //}

        //}

        //}




        /*public void kiemtratontai()
        {
            try
            {
                con = new SqlConnection();
                con.Open();
                string ct = "select name from Product where name='" + txtProductName.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Tên sản phẩm đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductName.Text = "";
                    txtProductName.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
    }
}
