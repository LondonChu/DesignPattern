using System.Windows.Forms;

namespace Thread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetMessage("Hello", Label);
        }

        private delegate void Delegate(string message, Control control);
        private void SetMessage(string message, Control control)
        {
            if (InvokeRequired)
            {
                Invoke(new Delegate(SetMessage), message, control);
            }
            else
            {
                control.Text = message;
            }
        }
    }
}
