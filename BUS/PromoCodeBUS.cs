using MiniStore.DAO;
using MiniStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore.BUS
{
    public class PromoCodeBUS
    {
        public static DataTable getAllPromo()
        {
            return PromoCodeDAO.getAllPromo();
        }
        public static bool addPromo(PromoCodeDTO code)
        {
            return (PromoCodeDAO.addPromo(code) == 1);
        }
        public static PromoCodeDTO selectPromo(string productid, int quantity, int price)
        {
            DataTable data = PromoCodeDAO.selectPromo(productid);
            if (data == null || data.Rows.Count < 1)
            {
                return null;
            }
            float discount = 0;
            string code = "";
            foreach(DataRow row in data.Rows)
            {
                if (quantity < (int)row[2])
                    continue;
                if (float.Parse(row[3].ToString()) < 0 && discount < float.Parse(row[3].ToString()) * price)
                {
                    discount = float.Parse(row[3].ToString()) * price / (int)row[2];
                    code = row[0].ToString();
                }
                if (float.Parse(row[3].ToString()) > 0 && discount < float.Parse(row[3].ToString()) * quantity)
                {
                    discount = float.Parse(row[3].ToString()) * quantity / (int)row[2];
                    code = row[0].ToString();
                }
            }
            data = PromoCodeDAO.getPromo(code);
            return new PromoCodeDTO(
                    (string)data.Rows[0][0],
                    data.Rows[0][1].ToString(),
                    (int)data.Rows[0][2],
                    float.Parse(data.Rows[0][3].ToString()),
                    (DateTime)data.Rows[0][4],
                    (DateTime)data.Rows[0][5]
                );
        }
    }
}
