using MiniStore.DTO;
using System.Data;

namespace MiniStore.DAO
{
    public static class ConsumerDAO
    {
        private static Connection conn = new Connection();

        public static DataTable getAllConsumer()
        {
            return conn.executeQuery("select phone, name, points, birthday from consumer where available = 1");
        }

        public static int addConsumer(ConsumerDTO consumer)
        {
            return conn.executeNonQuery($"insert into consumer values('{consumer.Phone}', N'{consumer.Name}', "
                + $"{consumer.Point}, '{consumer.Birthday}', 1)");
        }
        public static int removeConsumer(string PhoneNumber)
        {
            return conn.executeNonQuery($"update consumer set available = 0 where phone = '{PhoneNumber}'");
        }
        public static DataTable searchAdvance(string column, string searchtext)
        {
            return conn.executeQuery("select phone, name, points, birthday" +
                $" from consumer where available = 1 and {column} like '%{searchtext}%'");
        }
    }
}
