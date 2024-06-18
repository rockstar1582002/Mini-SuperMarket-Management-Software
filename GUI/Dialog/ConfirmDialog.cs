namespace MiniStore.GUI.Items
{
    public class ConfirmDialog
    {
        public static Confirmation Confirm;
        private static MyDialog myD;
        public ConfirmDialog(string message)
        {
            Confirm = new Confirmation(message);
            myD = new MyDialog(Confirm);
            Confirm.parent = myD;
            myD.ShowDialog();
        }
        public static void Show(string message)
        {
            Confirm = new Confirmation(message);
            myD = new MyDialog(Confirm);
            Confirm.parent = myD;
            myD.ShowDialog();
        }
    }
}
