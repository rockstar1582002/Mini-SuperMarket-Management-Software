using MiniStore.DTO;
using System;
using System.Windows.Forms;

namespace MiniStore.GUI.Features
{
    public partial class Inventory : UserControl
    {
        private EmployeeDTO Employee;
        public Inventory(EmployeeDTO employee)
        {
            Employee = employee;
            InitializeComponent();
        }

        private void Inventory_tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Inventory_tab.SelectedIndex)
            {
                case 0:
                    this.Product.load_data();
                    break;
                case 1:
                    this.InputMng.load_data();
                    break;
            }
        }
    }
}
