using MiniStore.DTO;
using MiniStore.GUI.Controls;

namespace MiniStore.GUI.Features
{

    public class EmployeeSetting
    {
        private static MyDialog dialog;
        public static void Show(int mode)
        {
            EmployeeItem setting = new EmployeeItem(mode);
            dialog = new MyDialog(setting);
            setting.parent = dialog;
            dialog.ShowDialog();
        }

        public static void Show(int mode, EmployeeDTO user)
        {
            EmployeeItem setting = new EmployeeItem(mode);
            setting.initUser(user);
            dialog = new MyDialog(setting);
            setting.parent = dialog;
            dialog.ShowDialog();
        }
    }
}
