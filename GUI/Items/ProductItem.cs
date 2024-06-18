using MiniStore.BUS;
using MiniStore.DTO;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MiniStore.GUI.Items
{
    public partial class ProductItem : UserControl
    {
        public Form parent;
        private ProductDTO product = null;
        public ProductItem()
        {
            InitializeComponent();
            Price_txt.TextChanged += Price_txt_TxtTextChanged;
            Qty_txt.TextChanged += Qty_txt_TextChanged;
            Provider_cbo.DataSource = ProviderBUS.getProvidersCollection();
            Qty_label.Visible = false;
            Qty_txt.Visible = false;
            Category_cbo.Text = "Food";
            Qty_txt.Texts = "0";
        }
        public ProductItem(ProductDTO product)
        {
            InitializeComponent();
            Price_txt.TextChanged += Price_txt_TxtTextChanged;
            Qty_txt.TextChanged += Qty_txt_TextChanged;
            Provider_cbo.DataSource = ProviderBUS.getProvidersCollection();
            this.product = product;
            initProduct();
        }

        private void initProduct()
        {
            Name_txt.Texts = product.Name;
            Unit_txt.Texts = product.Unit;
            Price_txt.Texts = $"{product.Price}";
            Category_cbo.Text = product.Category;
            Provider_cbo.Text = product.Provider;
            Image_pic.ImageLocation = product.Imgdir;
            Qty_txt.Texts = $"{product.Quantity}";
        }

        private void Price_txt_TxtTextChanged(object sender, EventArgs e)
        {
            if (Price_txt.Texts.Length > 0)
            {
                if (!(new Regex(@"^[0-9\b]+$").IsMatch(Price_txt.Texts)))
                {
                    Price_txt.Texts = Price_txt.Texts.Remove(Price_txt.Texts.Length - 1, 1);
                }
            }
        }
        private void Qty_txt_TextChanged(object sender, EventArgs e)
        {
            if (Qty_txt.Texts.Length > 0)
            {
                if (!(new Regex(@"^[0-9\b]+$").IsMatch(Qty_txt.Texts)))
                {
                    Qty_txt.Texts = Qty_txt.Texts.Remove(Qty_txt.Texts.Length - 1, 1);
                }
            }
        }

        private bool Validation()
        {
            return !(Name_txt.Texts == "" ||
                    Unit_txt.Texts == "" ||
                    Price_txt.Texts == "" ||
                    Qty_txt.Texts == "");
        }
        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            if (!Validation())
            {
                MessageDialog.Show("Invalid Data");
                return;
            }

            if (product != null)
            {
                product.Name = Name_txt.Texts;
                product.Unit = Unit_txt.Texts;
                product.Quantity = int.Parse(Qty_txt.Texts);
                product.Category = Category_cbo.Text;
                product.Price = int.Parse(Price_txt.Texts);
                product.Imgdir = Image_pic.ImageLocation;
                product.Provider = Provider_cbo.Text;
                if (ProductBUS.updateProduct(product))
                {
                    MessageDialog.Show("Update Product Successfull", true);
                    this.Dispose();
                    parent.Close();
                }
                else
                {
                    MessageDialog.Show("An Error Occurred !!!");
                }
                return;
            }

            product = new ProductDTO(
                Name_txt.Texts,
                Unit_txt.Texts,
                0,
                Category_cbo.Text,
                int.Parse(Price_txt.Texts),
                Image_pic.ImageLocation,
                Provider_cbo.Text
                ); ;
            if (ProductBUS.addProduct(product))
            {
                MessageDialog.Show("Add Product Successfull", true);
                this.Dispose();
                parent.Close();
            }
            else
            {
                MessageDialog.Show("An Error Occurred !!!");
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
                this.Image_pic.ImageLocation = open.FileName;
            }
        }
    }
}
