using MiniStore.DAO;
using MiniStore.DTO;
using System.Data;

namespace MiniStore.BUS
{
    public static class EmployeeBUS
    {
        public static EmployeeDTO getEmployee(string id)
        {
            DataTable data = EmployeeDAO.getEmployee(id);
            if (data.Rows.Count < 1) return null;
            EmployeeDTO emp = new EmployeeDTO
                (
                data.Rows[0][0].ToString(),
                data.Rows[0][1].ToString(),
                data.Rows[0][2].ToString(),
                data.Rows[0][3].ToString(),
                data.Rows[0][4].ToString(),
                data.Rows[0][5].ToString()
                );

            return emp;
        }
        public static DataTable getAllEmployee()
        {
            return EmployeeDAO.getAllEmployee();
        }
        public static bool addEmployee(EmployeeDTO employee)
        {
            return (EmployeeDAO.addEmployee(employee) != 0);
        }
        public static int updateEmployee(EmployeeDTO employee)
        {
            return EmployeeDAO.updateEmployee(employee);
        }
        public static int removeEmployee(string id)
        {
            return EmployeeDAO.removeEmployee(id);
        }
        public static DataTable searchAdvance(string column, string searchtext)
        {
            return EmployeeDAO.searchAdvance(column, searchtext);
        }
    }
}
