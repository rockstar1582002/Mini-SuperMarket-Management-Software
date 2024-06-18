using System.Data;

namespace MiniStore.DAO
{
    public static class ProviderDAO
    {
        private static Connection conn = new Connection();
        public static DataTable getAllProvider()
        {
            return conn.executeQuery("select id, name, direction, phone from provider");
        }
    }
}
