using MiniStore.DTO;
using System.Collections.Generic;
using System.Data;

namespace MiniStore.DAO
{
    public static class InputDetailDAO
    {
        private static Connection conn = new Connection();
        public static DataTable getAllInputDetail()
        {
            return conn.executeQuery("select inputid, productid, quantity, price from inputdetail where available = 1");
        }
        public static int addDetail(InputDetailDTO input, string ID)
        {
            return conn.executeNonQuery("insert into inputdetail (inputid, productid, quantity, price, available) " +
                $"values ('{ID}', '{input.Productid}', '{input.Quantity}', '{input.Price}', 1)");
        }
        public static int addDetail(InputDetailDTO input)
        {
            return conn.executeNonQuery("insert into inputdetail (inputid, productid, quantity, price, available) " +
                $"values ('{input.Inputid}', '{input.Productid}', '{input.Quantity}', '{input.Price}', 1)");
        }
        public static DataTable getInputDetails(InputDTO input)
        {
            return conn.executeQuery(
                "select inputid, productid, quantity, price from inputdetail where available = 1 " +
                $"and inputid = {input.Id}"
                );
        }

        public static int updateDetails(List<InputDetailDTO> details)
        {
            int count = conn.executeNonQuery($"update inputdetail set available = 0 where inputid = {details[0].Inputid}");
            foreach (InputDetailDTO detail in details)
            {
                if (addDetail(detail) != 0)
                {
                    ProductDAO.changeQuantity(detail.Inputid, detail.Quantity);
                }
                else
                {
                    conn.executeNonQuery(
                        $"update inputdetail set available = 1, quantity = {detail.Quantity}, price = {detail.Price}" +
                        $"where inputid = {detail.Inputid} and productid = {detail.Productid}"
                        );
                }
                count++;
            }
            return count;
        }
        public static DataTable getQuantityDetails(string InputID)
        {
            return conn.executeQuery(
                "select productid, inputdetail.quantity, product.quantity from inputdetail, product " +
                $"where inputid = {InputID} and productid = id"
                );
        }
    }
}
