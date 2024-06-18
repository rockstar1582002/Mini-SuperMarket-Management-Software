using MiniStore.BUS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiniStore.GUI.Features
{
    public partial class Invoices : UserControl
    {
        public Invoices()
        {
            InitializeComponent();
            date_1.CustomFormat = "dd-MM-yyyy";
            date_2.CustomFormat = "dd-MM-yyyy";
            date_2.Value= DateTime.Now;
            Invoice_gridview.DataSource = InvoiceBUS.getAllInvoice();
            
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            MyDialog dialog = new MyDialog(payment);
            dialog.setTaskBarColor(Color.BlueViolet);
            dialog.ShowDialog();

            Invoice_gridview.DataSource = InvoiceBUS.getAllInvoice();
        }
    }
}
