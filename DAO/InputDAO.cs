using MiniStore.DTO;
using System;
using System.Data;

namespace MiniStore.DAO
{
    public static class InputDAO
    {
        private static Connection conn = new Connection();
        public static DataTable getAllInput()
        {
            return conn.executeQuery("select id, receiver, price, date from input where  available = 1");
        }
        public static int addInput(InputDTO input)
        {
            return conn.executeNonQuery("insert into input (receiver, price, date, available) " +
                $"values ('{input.Receiver}', {input.Price}, '{input.Date.ToString("dd-MM-yyyy HH:mm:ss.fff")}', 1)");
        }
        public static int updateInput(InputDTO input)
        {
            return conn.executeNonQuery(
                "update input set " +
                $"receiver = '{input.Receiver}', price = {input.Price}, date = '{input.Date.ToString("dd-MM-yyyy HH:mm:ss.fff")}', available = 1 " +
                $"where id = {input.Id}"
                );
        }

        public static DataTable getLastedInput()
        {
            return conn.executeQuery("select top 1 id, receiver, price, date from input order by id desc");
        }
        public static DataTable getInputWithFilter(DateTime date_1, DateTime date_2)
        {
            return conn.executeQuery(
                "select id, receiver, price, date from input " +
                $"where available = 1 and date between '{date_1.ToString("dd-MM-yyyy")}' and '{date_2.ToString("dd-MM-yyyy")}'"
                );
        }
        public static DataTable searchInput(string keywords)
        {
            return conn.executeQuery(
                "select id, receiver, price, date from input " +
                $"where  available = 1 and id like '%{keywords}%'"
                );
        }
        public static void removeInput(string ID)
        {
            conn.executeNonQuery("update input set available = 0 where id = " + ID);
        }
    }
}
