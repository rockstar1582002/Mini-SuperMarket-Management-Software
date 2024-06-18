using MiniStore.DAO;
using MiniStore.DTO;
using System.Data;

namespace MiniStore.BUS
{
    public static class InputDetailBUS
    {
        public static DataTable getAllInputDetail()
        {
            return InputDetailDAO.getAllInputDetail();
        }

        public static int addInputDetail(InputDetailDTO detail)
        {
            return InputDetailDAO.addDetail(detail);
        }
        public static DataTable getInputDetails(InputDTO input)
        {
            return InputDetailDAO.getInputDetails(input);
        }
    }
}
