using MiniStore.BUS;
using MiniStore.DTO;
using MiniStore.GUI.Items;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MiniStore.GUI.Features
{
    public partial class ConsumerItem : UserControl
    {
        public Form parent;
        public ConsumerItem()
        {
            InitializeComponent();
            Points_txt.Texts = "0";
            Points_txt.Enabled = false;
        }

        public ConsumerItem(ConsumerDTO consumer)
        {
            InitializeComponent();
            Phone_txt.Texts = consumer.Phone;
            Name_txt.Texts = consumer.Name;
            Points_txt.Texts = consumer.Point.ToString();
            Birth_DTP.Value = DateTime.Parse(consumer.Birthday);
            Phone_txt.Enabled = false;

        }

        private bool checkInput()
        {
            if (Phone_txt.Texts.Length == 0)
            {
                MessageDialog.Show("Please fill in Phone Number");
                return false;
            }
            if (Phone_txt.Texts.Length != 10 || !(new Regex(@"^[0-9]+$").IsMatch(Phone_txt.Texts)))
            {
                MessageDialog.Show("Invalid Phone Number");
                return false;
            }
            return true;
        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            if (!checkInput()) return;
            ConsumerDTO consumer = new ConsumerDTO(
                Phone_txt.Texts,
                Name_txt.Texts,
                int.Parse(Points_txt.Texts),
                String.Format("{0:MM/dd/yyyy}", Birth_DTP.Value.Date)
                );
            if (ConsumerBUS.addConsumer(consumer))
            {
                MessageDialog.Show("Add Consumer Succesfully");
                this.Dispose();
                parent.Close();
                return;
            }
            MessageDialog.Show("Failed to add Consumer");
        }
    }
}
