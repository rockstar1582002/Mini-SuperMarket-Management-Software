namespace MiniStore.DTO
{
    public class ProviderDTO
    {
        private string _id;
        private string _name;
        private string _direction;
        private string _phone;

        public ProviderDTO(string id, string name, string direction, string phone)
        {
            _id = id;
            Name = name;
            Direction = direction;
            Phone = phone;
        }

        public string Id { get => _id; }
        public string Name { get => _name; set => _name = value; }
        public string Direction { get => _direction; set => _direction = value; }
        public string Phone { get => _phone; set => _phone = value; }
    }
}
