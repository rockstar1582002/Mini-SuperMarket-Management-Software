using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore.DAO
{
    public static class InvoiceDAO
    {
        private static Connection conn = new Connection();
        public static DataTable getAllInvoice()
        {
            return conn.executeQuery("select id, cashier, consumer, price, date from invoice");
        }

    }
}
