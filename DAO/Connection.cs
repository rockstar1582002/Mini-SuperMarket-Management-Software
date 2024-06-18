using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace MiniStore.DAO
{
    public class Connection
    {
        private string ConnStr;
        private SqlCommand cmd;
        private SqlConnection conn;
        public Connection()
        {
            ConnStr = @"Data Source=LAPTOP-I2IUK1M1\SQLEXPRESS01;Initial Catalog=ministore_csharp;Integrated Security=True";
            conn = new SqlConnection(ConnStr);
        }
        public int executeNonQuery(string sqlStr)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sqlStr, conn);
                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                return rows;
            }
            catch
            {
                conn.Close();
                return 0;
            }
        }
        public DataTable executeQuery(string sqlStr)
        {
            try
            {
                conn.Open();
                DataAdapter da = new SqlDataAdapter(sqlStr, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                conn.Close();
                return ds.Tables[0];
            }
            catch
            {
                conn.Close();
                return null;
            }
        }
    }
}
