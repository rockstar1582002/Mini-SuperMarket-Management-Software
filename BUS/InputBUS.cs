using MiniStore.DAO;
using MiniStore.DTO;
using MiniStore.GUI.Items;
using System;
using System.Collections.Generic;
using System.Data;

namespace MiniStore.BUS
{
    public static class InputBUS
    {
        public static DataTable getAllInput()
        {
            return InputDAO.getAllInput();
        }
        public static bool addInput(InputDTO input, List<InputDetailDTO> details)
        {
            if (InputDAO.addInput(input) == 0) return false;
            string id = InputDAO.getLastedInput().Rows[0][0].ToString();
            foreach (InputDetailDTO detail in details)
            {
                if (InputDetailDAO.addDetail(detail, id) == 0 ||
                    !ProductBUS.changeQuantity(detail.Productid, detail.Quantity)) return false;
            }
            return true;
        }
        public static bool updateInput(InputDTO input, List<InputDetailDTO> details)
        {

            DataTable oldData = InputDetailDAO.getQuantityDetails(input.Id);
            int QtyChange;
            if (oldData != null)
            {
                for (int i = 0; i < oldData.Rows.Count; i++)
                {
                    QtyChange = -(int)oldData.Rows[i][1];
                    foreach (InputDetailDTO detail in details)
                    {
                        if (detail.Productid == oldData.Rows[i][0].ToString())
                        {
                            QtyChange = detail.Quantity - (int)oldData.Rows[i][1];
                            break;
                        }
                    }
                    if ((int)oldData.Rows[i][2] + QtyChange < 0)
                    {
                        MessageDialog.Show("Invalid Quantity!!!\nProduct: " + oldData.Rows[i][0].ToString());
                        return false;
                    }
                    ProductDAO.changeQuantity(oldData.Rows[i][0].ToString(), QtyChange);
                }
            }
            if (InputDAO.updateInput(input) == 0) return false;
            if (InputDetailDAO.updateDetails(details) == 0) return false;
            return true;
        }
        public static DataTable getInputWithFilter(DateTime date_1, DateTime date_2)
        {
            return InputDAO.getInputWithFilter(date_1, date_2);
        }
        public static DataTable searchInput(string keywords)
        {
            return InputDAO.searchInput(keywords);
        }
        public static void removeInput(string ID)
        {
            InputDAO.removeInput(ID);
        }
    }
}
