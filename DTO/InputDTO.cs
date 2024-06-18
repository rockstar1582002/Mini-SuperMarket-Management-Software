using System;

namespace MiniStore.DTO
{
    public class InputDTO
    {
        private string _id;
        private string _receiver;
        private int _price;
        private DateTime _date;

        public InputDTO(string id, string receiver, int price, DateTime date)
        {
            _id = id;
            _receiver = receiver;
            _price = price;
            _date = date;
        }
        public InputDTO(string receiver, int price, DateTime date)
        {
            _receiver = receiver;
            _price = price;
            _date = date;
        }

        public string Id { get => _id; }
        public string Receiver { get => _receiver; set => _receiver = value; }
        public int Price { get => _price; set => _price = value; }
        public DateTime Date { get => _date; set => _date = value; }
    }
}
