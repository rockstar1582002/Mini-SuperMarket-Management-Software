namespace MiniStore.DTO
{
    public class InputDetailDTO
    {
        private string _inputid;
        private string _productid;
        private int _quantity;
        private int _price;

        public InputDetailDTO(string inputid, string productid, int quantity, int price)
        {
            _inputid = inputid;
            _productid = productid;
            _quantity = quantity;
            _price = price;
        }
        public InputDetailDTO(string productid, int quantity, int price)
        {
            _productid = productid;
            _quantity = quantity;
            _price = price;
        }

        public string Inputid { get => _inputid; set => _inputid = value; }
        public string Productid { get => _productid; set => _productid = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public int Price { get => _price; set => _price = value; }
    }
}
