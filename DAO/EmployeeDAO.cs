using MiniStore.DTO;
using System.Data;

namespace MiniStore.DAO
{
    public static class EmployeeDAO
    {
        private static Connection conn = new Connection();

        public static int updateEmployee(EmployeeDTO employee)
        {
            return conn.executeNonQuery(employee.getUpdateSQL());
        }
        public static DataTable getEmployee(string id)
        {
            return conn.executeQuery($"select * from employee where id = '{id}' and available = 1");
        }
        public static DataTable getAllEmployee()
        {
            return conn.executeQuery("select id, pass, role, name, phone, imgdir from Employee where available = 1");

        }
        public static int addEmployee(EmployeeDTO employee)
        {
            return conn.executeNonQuery(employee.getInsertSQL());
        }
        public static int removeEmployee(string id)
        {
            return conn.executeNonQuery($"update employee set available = 0 where id = '{id}'");
        }
        public static DataTable searchAdvance(string column, string searchtext)
        {
            return conn.executeQuery("select id, pass, role, name, phone," +
                $" imgdir from Employee where available = 1 and {column} like '%{searchtext}%'");
        }


    }
}
