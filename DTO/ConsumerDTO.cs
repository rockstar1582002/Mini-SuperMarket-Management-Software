namespace MiniStore.DTO
{
    public class ConsumerDTO
    {
        private string _phone;
        private string _name;
        private int _point;
        private string _birthday;

        public ConsumerDTO(string phone, string name, string birthday)
        {
            _phone = phone;
            _name = name;
            _point = 0;
            _birthday = birthday;
        }

        public ConsumerDTO(string phone, string name, int point, string birthday)
        {
            _phone = phone;
            _name = name;
            _point = point;
            _birthday = birthday;
        }

        public string Phone { get => _phone; }
        public string Name { get => _name; set => _name = value; }
        public int Point { get => _point; set => _point = value; }
        public string Birthday { get => _birthday; set => _birthday = value; }
    }
}
