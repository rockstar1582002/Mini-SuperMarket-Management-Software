using MiniStore.BUS;
using MiniStore.DTO;
using MiniStore.ExtendedFeatures;
using MiniStore.GUI.Items;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MiniStore.GUI.Features
{
    public partial class Payment : UserControl
    {
        private Barcode Scanner;
        private EmployeeDTO Employee;
        private InputDTO DTO;
        private List<PromoCodeDTO> PromoCodes;
        public Form parent;

        public Payment()
        {
            InitializeComponent();
            Scanner = new Barcode();
            Recieved_txt.TextChanged += Recieved_txt_TextChanged;
            Quantity_txt.TextChanged += Quantity_txt_TextChanged;
            ID_txt.TextChanged += ID_txt_TextChanged;

            Search_gridview.DataSource = ProductBUS.getAllProduct();
        }

        private void ID_txt_TextChanged(object sender, EventArgs e)
        {
            if (ID_txt.Texts.Length > 0)
            {
                if (!(new Regex(@"^[0-9\b]+$").IsMatch(ID_txt.Texts)))
                {
                    ID_txt.Texts = ID_txt.Texts.Remove(ID_txt.Texts.Length - 1, 1);
                }
            }
        }

        private void Quantity_txt_TextChanged(object sender, EventArgs e)
        {
            if (Quantity_txt.Texts.Length > 0)
            {
                if (!(new Regex(@"^[0-9\b]+$").IsMatch(Quantity_txt.Texts)))
                {
                    Quantity_txt.Texts = Quantity_txt.Texts.Remove(Quantity_txt.Texts.Length - 1, 1);
                }
            }
        }

        private void Recieved_txt_TextChanged(object sender, EventArgs e)
        {
            if (Recieved_txt.Texts.Length > 0)
            {
                if (!(new Regex(@"^[0-9\b]+$").IsMatch(Recieved_txt.Texts)))
                {
                    Recieved_txt.Texts = Recieved_txt.Texts.Remove(Recieved_txt.Texts.Length - 1, 1);
                }
            }
        }
        private bool Validation()
        {
            if (Quantity_txt.Texts == "" || ID_txt.Texts == "")
            {
                MessageDialog.Show("Some fields are Empty!!!");
                return false;
            }
            bool flag = false;
            foreach(DataGridViewRow row in Search_gridview.Rows)
            {
                if (row.Cells[0].Value.ToString() == ID_txt.Texts)
                {
                    flag = true;
                    if ((int)row.Cells[3].Value < int.Parse(Quantity_txt.Texts))
                    {
                        MessageDialog.Show("There is not enough Product!!!");
                        return false;
                    }
                    break;
                }   
            }
            if (!flag)
            {
                MessageDialog.Show($"There is no Product ID: {ID_txt.Texts}");
                return false;
            }
            return true;
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (!Validation())
                return;
            foreach(DataGridViewRow dataRow in Invoice_gridview.Rows)
            {
                if (dataRow.Cells[0].Value.ToString() == ID_txt.Texts)
                {

                }
            }

            string name = "";
            int price = 0;
            foreach (DataGridViewRow searchrow in Search_gridview.Rows)
            {
                if (searchrow.Cells[0].Value.ToString() == ID_txt.Texts)
                {
                    name = (string)searchrow.Cells[1].Value;
                    price = (int)searchrow.Cells[5].Value;
                    break;
                }
            }
            price *= int.Parse(Quantity_txt.Texts);
            PromoCodeDTO promocode = PromoCodeBUS.selectPromo(ID_txt.Texts, int.Parse(Quantity_txt.Texts), price);
            float discount = 0;
            if (promocode != null)
            {
                discount = promocode.Discount * int.Parse(Quantity_txt.Texts) / promocode.Quantity;
                PromoCodes.Add(promocode);
            }
            Invoice_gridview.Rows.Add(new object[] { null, null, null, null, null, null });
            DataGridViewRow row = (DataGridViewRow)Invoice_gridview.Rows[0].Clone();
            Invoice_gridview.Rows.RemoveAt(Invoice_gridview.Rows.Count - 1);
            row.Cells[0].Value = ID_txt.Texts;
            row.Cells[1].Value = name;
            row.Cells[2].Value = Quantity_txt.Texts;
            row.Cells[3].Value = price;
            row.Cells[4].Value = Math.Round(discount);
            row.Cells[5].Value = Math.Round(price - discount);
            Invoice_gridview.Rows.Add(row);
            
        }

        private void Search_gridview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Search_gridview.SelectedRows.Count == 0)
                return;
            ID_txt.Texts = Search_gridview.SelectedRows[0].Cells[0].Value.ToString();
            Quantity_txt.Texts = "1";
        }
        private void Scan_btn_Click_1(object sender, EventArgs e)
        {
            Scanner.Scan(Barcode_pic, Product_img, ID_txt, Quantity_txt);
        }

        private void Stop_btn_Click_1(object sender, EventArgs e)
        {
            Scanner.Stop();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            Search_gridview.DataSource = ProductBUS.searchAdvance("name", Search_txt.Texts);
        }
    }
}