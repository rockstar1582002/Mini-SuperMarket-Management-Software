using MiniStore.BUS;
using MiniStore.DTO;
using MiniStore.GUI.Items;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace khuyenmai
{
    public partial class khuyenmai : UserControl
    {
        public khuyenmai()
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Value = DateTime.Now;   
            load_data();
        }
        private void load_data()
        {
            dataGridView1.DataSource = ProductBUS.getAllProduct();
            dataGridView2.DataSource= PromoCodeBUS.getAllPromo();
        }
        private bool Validation()
        {
            if (textBox1.Text == "" ||
                textBox2.Text == "" ||
                textBox3.Text == "" ||
                textBox4.Text == "")
            {
                MessageDialog.Show("Some fields are Empty");
                return false;
            }

            if (ProductBUS.getProduct(textBox2.Text) == null) 
            {
                MessageDialog.Show("Invalid Product!!!");
                return false;
            } 
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageDialog.Show("Invalid Date Start/Expire");
                return false;
            }
            return true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 0)
            {
                if (!(new Regex(@"^[0-9\b]+$").IsMatch(textBox3.Text)))
                {
                    textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1, 1);
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 0)
            {
                if (!(new Regex(@"^[0-9\b.]+$").IsMatch(textBox4.Text)))
                {
                    textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1, 1);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validation()) return;
            if (PromoCodeBUS.addPromo(
                new PromoCodeDTO(
                        textBox1.Text,
                        textBox2.Text,
                        int.Parse(textBox3.Text),
                        float.Parse(textBox4.Text),
                        dateTimePicker1.Value,
                        dateTimePicker2.Value
                    )
                ))
            {
                MessageDialog.Show("Add PromoCode Successfully");
            }
            load_data();
        }
    }
}
