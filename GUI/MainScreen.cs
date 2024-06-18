using FontAwesome.Sharp;
using Kho;
using MiniStore.DTO;
using MiniStore.GUI.Controls;
using MiniStore.GUI.Features;
using MiniStore.GUI.Items;
using QLKH_QLNV;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MiniStore.GUI
{
    public partial class MainScreen : Form
    {
        private EmployeeDTO employee;
        private MainControl main;
        private FeaturesControl feature = new FeaturesControl();
        private LoginControl login;

        private Invoices Invoices;
        private Inventory Inventory;
        private QLNV EmployeeMng;
        private QLKH ConsumerMng;
        private Management Management;
        private EmployeeItem AccountSetting;



        private List<FeatureIcon> BigFeatures = new List<FeatureIcon>();
        private List<FeatureButton> SmallFeatures = new List<FeatureButton>();
        private FeatureIcon B_cashier;
        private FeatureIcon B_inventory;
        private FeatureIcon B_management;
        private FeatureIcon B_statistic;
        private FeatureIcon B_setting;
        private FeatureIcon B_help;
        private FeatureButton s_cashier;
        private FeatureButton s_inventory;
        private FeatureButton s_management;
        private FeatureButton s_statistic;
        private FeatureButton s_setting;
        private FeatureButton s_help;

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = 0x00020000;
                return cp;
            }
        }

        private void initLogin()
        {

            login = new LoginControl(this);
            main = new MainControl(this);



            login.Dock = DockStyle.Fill;
            feature.Dock = DockStyle.Fill;
            main.Dock = DockStyle.Fill;

            this.DoubleBuffered = true;
            this.ScreenPanel.Controls.Add(login);
        }
        private void initFeatures()
        {
            FeatureIcon.main = this;

            B_cashier = new FeatureIcon();
            B_inventory = new FeatureIcon();
            B_management = new FeatureIcon();
            B_statistic = new FeatureIcon();
            B_setting = new FeatureIcon();
            B_help = new FeatureIcon();


            B_cashier.setFeatureName("Cashier");
            B_inventory.setFeatureName("Inventory");
            B_management.setFeatureName("Manager");
            B_statistic.setFeatureName("Statistic");
            B_setting.setFeatureName("Account Set8ting");
            B_help.setFeatureName("Help");

            B_inventory.setIcon(IconChar.Warehouse);
            B_management.setIcon(IconChar.UsersGear);
            B_statistic.setIcon(IconChar.ChartColumn);
            B_setting.setIcon(IconChar.Gears);
            B_help.setIcon(IconChar.CircleInfo);

            FeatureButton.main = this;

            s_cashier = new FeatureButton();
            s_inventory = new FeatureButton();
            s_management = new FeatureButton();
            s_statistic = new FeatureButton();
            s_setting = new FeatureButton();
            s_help = new FeatureButton();

            s_cashier.IconChar = IconChar.MoneyBill1Wave;
            s_inventory.IconChar = IconChar.Warehouse;
            s_management.IconChar = IconChar.UserGear;
            s_statistic.IconChar = IconChar.ChartColumn;
            s_setting.IconChar = IconChar.Gears;
            s_help.IconChar = IconChar.CircleInfo;

            B_cashier.Fname = s_cashier.Fname = FeatureName.Cashier;
            B_inventory.Fname = s_inventory.Fname = FeatureName.Inventory;
            B_management.Fname = s_management.Fname = FeatureName.Management;
            B_statistic.Fname = s_statistic.Fname = FeatureName.Statistic;
            B_setting.Fname = s_setting.Fname = FeatureName.Setting;
            B_help.Fname = s_help.Fname = FeatureName.Help;


        }
        public MainScreen()
        {
            InitializeComponent();
            initLogin();
            initFeatures();
        }

        public void LoginEvent(EmployeeDTO user)
        {

            Invoices = new Invoices();
            Inventory = new Inventory(user);
            EmployeeMng = new QLNV();
            ConsumerMng = new QLKH();
            Management = new Management();
            AccountSetting = new EmployeeItem(0);

            switch (user.Role)
            {
                case EmployeeRole.Cashier:
                    SmallFeatures.Add(s_cashier);
                    SmallFeatures.Add(s_setting);
                    SmallFeatures.Add(s_help);

                    BigFeatures.Add(B_cashier);
                    BigFeatures.Add(B_setting);
                    BigFeatures.Add(B_help);
                    break;
                case EmployeeRole.InventoryManger:
                    SmallFeatures.Add(s_inventory);
                    SmallFeatures.Add(s_setting);
                    SmallFeatures.Add(s_help);

                    BigFeatures.Add(B_inventory);
                    BigFeatures.Add(B_setting);
                    BigFeatures.Add(B_help);
                    break;
                default:
                    SmallFeatures.Add(s_cashier);
                    SmallFeatures.Add(s_inventory);
                    SmallFeatures.Add(s_management);
                    SmallFeatures.Add(s_statistic);
                    SmallFeatures.Add(s_setting);
                    SmallFeatures.Add(s_help);

                    BigFeatures.Add(B_cashier);
                    BigFeatures.Add(B_inventory);
                    BigFeatures.Add(B_management);
                    BigFeatures.Add(B_statistic);
                    BigFeatures.Add(B_setting);
                    BigFeatures.Add(B_help);
                    break;
            }

            feature.init(user.Name, user.Imgdir);
            main.init(user.Imgdir);

            feature.AddFeatures(BigFeatures);
            main.AddFeatures(SmallFeatures);

            this.ScreenPanel.Controls.Clear();
            this.ScreenPanel.Controls.Add(feature);
            employee = user;
        }

        public void SwitchScreenEvent(bool signal)
        {
            this.ScreenPanel.Controls.Clear();
            if (signal)
            {
                ScreenPanel.Controls.Add(main);
                return;
            }
            ScreenPanel.Controls.Add(feature);
        }

        public void SwitchFeatureEvent(FeatureName f)
        {

            switch (f)
            {
                case FeatureName.Cashier:
                    main.SwitchFeature(Invoices, f);
                    break;
                case FeatureName.Management:
                    main.SwitchFeature(Management, f);
                    break;
                //case FeatureName.Consumer:
                //    main.SwitchFeature(ConsumerMng, f);
                //    break;
                case FeatureName.Setting:
                    AccountSetting.initUser(employee);
                    main.SwitchFeature(AccountSetting, f);
                    break;
                case FeatureName.Inventory:
                    main.SwitchFeature(Inventory, f);
                    break;
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {

            ConfirmDialog.Show("Exit Application?");
            if (ConfirmDialog.Confirm.Confimation)
            {
                this.Dispose();
            }

        }
        private bool isFullScreen = false;
        private void FullScreen_btn_Click(object sender, EventArgs e)
        {
            if (isFullScreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FullScreen_btn.IconChar = FontAwesome.Sharp.IconChar.Square;
                isFullScreen = false;
                return;
            }
            this.WindowState = FormWindowState.Maximized;
            this.FullScreen_btn.IconChar = FontAwesome.Sharp.IconChar.Compress;
            isFullScreen = true;

        }

        private void Hide_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
