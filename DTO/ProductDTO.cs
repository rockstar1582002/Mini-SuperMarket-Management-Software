namespace MiniStore.DTO
{
    public class ProductDTO
    {
        private string _id;
        private string _name;
        private string _unit;
        private int _quantity;
        private string _category;
        private int _price;
        private string _imgdir;
        private string _barcode;
        private string _provider;

        public ProductDTO(string id, string name, string unit, int quantity,
            string category, int price, string img, string barcode, string provider)
        {
            _id = id;
            _name = name;
            _unit = unit;
            _quantity = quantity;
            _category = category;
            _price = price;
            _imgdir = img;
            _barcode = barcode;
            _provider = provider;
        }
        public ProductDTO(string name, string unit, int quantity,
            string category, int price, string img, string provider)
        {
            _name = name;
            _unit = unit;
            _quantity = quantity;
            _category = category;
            _price = price;
            _imgdir = img;
            _provider = provider;
        }

        public string Id { get => _id; }
        public string Name { get => _name; set => _name = value; }
        public string Unit { get => _unit; set => _unit = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public string Category { get => _category; set => _category = value; }
        public int Price { get => _price; set => _price = value; }
        public string Imgdir { get => _imgdir; set => _imgdir = value; }
        public string Barcode { get => _barcode; set => _barcode = value; }
        public string Provider { get => _provider; set => _provider = value; }
    }
}
