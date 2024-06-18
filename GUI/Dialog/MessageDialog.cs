namespace MiniStore.GUI.Items
{

    public class MessageDialog
    {
        private static MyMessage myM;
        private static MyDialog myD;
        //public MessageDialog(string message)
        //{
        //    myM = new MyMessage(message);
        //    myD = new MyDialog(myM);
        //    myM.parent = myD;
        //    myD.ShowDialog();
        //}
        public static void Show(string message)
        {
            myM = new MyMessage(message);
            myD = new MyDialog(myM);
            myM.parent = myD;
            myD.ShowDialog();
        }
        public static void Show(string message, bool signal)
        {
            MyMessage myM = new MyMessage(message, signal);
            MyDialog myD = new MyDialog(myM);
            myM.parent = myD;
            myD.ShowDialog();
        }
    }
}
