using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore.DTO
{
    public class PromoCodeDTO
    {
        private string _code;
        private string _productid;
        private int _quantity;
        private float _discount;
        private DateTime _start_date;
        private DateTime _end_date;

        public PromoCodeDTO(string code, string productid, int quantity, float discount, DateTime start_date, DateTime end_date)
        {
            Code = code;
            Productid = productid;
            Quantity = quantity;
            Discount = discount;
            Start_date = start_date;
            End_date = end_date;
        }

        public string Code { get => _code; set => _code = value; }
        public string Productid { get => _productid; set => _productid = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public float Discount { get => _discount; set => _discount = value; }
        public DateTime Start_date { get => _start_date; set => _start_date = value; }
        public DateTime End_date { get => _end_date; set => _end_date = value; }
    }
}
