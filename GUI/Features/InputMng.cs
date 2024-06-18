using MiniStore.BUS;
using MiniStore.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiniStore.GUI.Items
{
    public partial class InputMng : UserControl
    {
        private EmployeeDTO Employee { get; set; }
        public InputMng(EmployeeDTO employee)
        {
            InitializeComponent();
            date_1.CustomFormat = "dd-MM-yyyy";
            date_2.CustomFormat = "dd-MM-yyyy";
            Employee = employee;
        }
        public void load_data()
        {
            date_2.Value = DateTime.Now;
            Input_gridview.DataSource = InputBUS.getAllInput();
        }
        private void DateFilter()
        {
            Input_gridview.DataSource = InputBUS.getInputWithFilter(date_1.Value, date_2.Value);
        }


        private void Search_btn_Click(object sender, EventArgs e)
        {
            Input_gridview.DataSource = InputBUS.searchInput(Search_txt.Text);
        }

        private void date_2_ValueChanged(object sender, EventArgs e)
        {
            DateFilter();
        }

        private void date_1_ValueChanged(object sender, EventArgs e)
        {
            DateFilter();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {

            Input input = new Input(Employee);
            MyDialog inputDialog = new MyDialog(input);
            input.parent = inputDialog;
            inputDialog.setTaskBarColor(Color.BlueViolet);
            inputDialog.ShowDialog();
            Input_gridview.DataSource = InputBUS.getAllInput();
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (Input_gridview.SelectedRows.Count == 0) return;
            DataGridViewRow row = Input_gridview.SelectedRows[0];
            InputDTO inputDTO = new InputDTO(
                    row.Cells[0].Value.ToString(),
                    row.Cells[1].Value.ToString(),
                    int.Parse(row.Cells[2].Value.ToString()),
                    (DateTime)row.Cells[3].Value
                );
            Input input = new Input(Employee, inputDTO);
            MyDialog inputDialog = new MyDialog(input);
            input.parent = inputDialog;
            inputDialog.setTaskBarColor(Color.BlueViolet);
            inputDialog.ShowDialog();
            Input_gridview.DataSource = InputBUS.getAllInput();
        }

        private void Remove_btn_Click(object sender, EventArgs e)
        {
            if (Input_gridview.SelectedRows.Count == 0) return;
            ConfirmDialog.Show("Remove Input: "+ Input_gridview.SelectedRows[0].Cells[0].Value + "?");
            if (ConfirmDialog.Confirm.Confimation)
            {
                InputBUS.removeInput(Input_gridview.SelectedRows[0].Cells[0].Value.ToString());
                Input_gridview.DataSource = InputBUS.getAllInput(); 
            }
        }
    }
}
