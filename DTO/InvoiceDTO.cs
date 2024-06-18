using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore.DTO
{
    public class InvoiceDTO
    {
        private string _id;
        private string _cashier;
        private string _consumer;
        private int _price;
        private DateTime _date;

        public InvoiceDTO(string cashier, string consumer, int price, DateTime date)
        {
            Cashier = cashier;
            Consumer = consumer;
            Price = price;
            Date = date;
        }

        public InvoiceDTO(string id, string cashier, string consumer, int price, DateTime date)
        {
            Id = id;
            Cashier = cashier;
            Consumer = consumer;
            Price = price;
            Date = date;
        }

        public string Id { get => _id; set => _id = value; }
        public string Cashier { get => _cashier; set => _cashier = value; }
        public string Consumer { get => _consumer; set => _consumer = value; }
        public int Price { get => _price; set => _price = value; }
        public DateTime Date { get => _date; set => _date = value; }
    }
}
