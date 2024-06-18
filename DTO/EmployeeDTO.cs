namespace MiniStore.DTO
{
    public enum EmployeeRole
    {
        Administrator,
        Cashier,
        InventoryManger,
        EmployeeManager
    };
    public class EmployeeDTO
    {
        private string _id;
        private string _name;
        private string _pass;
        private string _role;
        private string _phone;
        private string _imgdir;

        public string ID { get { return _id; } }
        public string Pass
        {
            get { return _pass; }
            set { _pass = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public EmployeeRole Role
        {
            get
            {
                switch (_role)
                {
                    case "Cashier":
                        return EmployeeRole.Cashier;
                    case "Inventory":
                        return EmployeeRole.InventoryManger;
                    case "Manager":
                        return EmployeeRole.EmployeeManager;
                    default:
                        return EmployeeRole.Administrator;
                }
            }
            set
            {
                switch (value)
                {
                    case EmployeeRole.Cashier:
                        _role = "Cashier";
                        break;
                    case EmployeeRole.InventoryManger:
                        _role = "Inventory";
                        break;
                    case EmployeeRole.EmployeeManager:
                        _role = "Manager";
                        break;
                    default:
                        _role = "Administrator";
                        break;
                }
            }
        }
        public string Phone
        {
            get { return _phone; }
            set { if (value.Length == 10) _phone = value; }
        }
        public string Imgdir
        {
            get { return _imgdir; }
            set { _imgdir = value; }
        }

        public EmployeeDTO() { }
        public EmployeeDTO(string ID, string PASS, string ROLE, string NAME, string PHONE, string IMG)
        {
            _id = ID;
            _pass = PASS;
            _role = ROLE;
            _name = NAME;
            _phone = PHONE;
            _imgdir = IMG;
        }
        public string getUpdateSQL()
        {
            return $"update employee set pass = '{_pass}', role = '{_role}', name = N'{_name}',"
                + $"phone = '{_phone}', imgdir = '{_imgdir}' where id = '{_id}'";
        }
        public string getInsertSQL()
        {
            return $"insert into employee values ('{_id}', '{_pass}', '{_role}', N'{_name}', '{_phone}', '{_imgdir}', 1)";
        }

    }
}
