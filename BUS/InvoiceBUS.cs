using MiniStore.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore.BUS
{
    public static class InvoiceBUS
    {
        public static DataTable getAllInvoice()
        {
            return InvoiceDAO.getAllInvoice();
        }
    }
}
