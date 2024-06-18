using MiniStore.DTO;

namespace MiniStore.GUI.Features
{
    public class ConsumerSetting
    {
        private static MyDialog dialog;
        public static void Show()
        {
            ConsumerItem consumer = new ConsumerItem();
            dialog = new MyDialog(consumer);
            consumer.parent = dialog;
            dialog.ShowDialog();
        }
        public static void Show(ConsumerDTO consumerDTO)
        {
            ConsumerItem consumer = new ConsumerItem(consumerDTO);
            dialog = new MyDialog(consumer);
            consumer.parent = dialog;
            dialog.ShowDialog();
        }
    }
}
