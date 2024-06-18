using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MiniStore.GUI
{
    public partial class MyDialog : Form
    {
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public MyDialog(UserControl control)
        {
            InitializeComponent();
            this.MessagePanel.Controls.Clear();
            this.Size = control.Size;
            this.MessagePanel.Controls.Add(control);
        }
        public MyDialog()
        {
            InitializeComponent();
        }
        public void initMessage(UserControl control)
        {
            this.MessagePanel.Controls.Clear();
            this.Size = control.Size;
            this.MessagePanel.Controls.Add(control);
        }
        public void setTaskBarColor(Color color)
        {
            this.TaskBar.BackColor = color;
        }

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void ButtonPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        private void TitlePanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        private void TaskBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
