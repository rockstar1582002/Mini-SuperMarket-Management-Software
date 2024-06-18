using MiniStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore.DAO
{
    public static class PromoCodeDAO
    {
        private static Connection conn = new Connection();
        public static DataTable getAllPromo()
        {
            return conn.executeQuery(
                "select code, productid, quantity, discount, startdate, expdate " +
                "from promocode where available = 1"
                );
          
        }
        public static int addPromo(PromoCodeDTO code)
        {
            return conn.executeNonQuery(
                $"insert into promocode values ('{code.Code}', '{code.Productid}', {code.Quantity}, "+
                $"{code.Discount}, '{code.Start_date.Date}', '{code.End_date.Date}', 1)"
                );
        }
        public static DataTable selectPromo(string producid)
        {
            return conn.executeQuery(
                $"select code, productid, quantity, discount, startdate, expdate " +
                $"from promocode where productid = {producid} and expdate >= '{DateTime.Now.Date}' and available = 1"
                );
        }
        public static DataTable getPromo(string code)
        {
            return conn.executeQuery(
                $"select code, productid, quantity, discount, startdate, expdate " +
                $"from promocode where code = '{code}' and available = 1"
                );
        }
    }
}
