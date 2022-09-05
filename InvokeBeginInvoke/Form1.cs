using System;
using System.Threading;
using System.Windows.Forms;

namespace InvokeBeginInvoke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void InvokeDelegate();

        #region Invoke
        Thread invokeThread;
        private void b_Invoke_Click(object sender, EventArgs e)
        {
            //主線程
            textBox1.Text += Thread.CurrentThread.GetHashCode().ToString() + "AAA" + "\r\n";
            invokeThread = new Thread(new ThreadStart(StartMethod));
            invokeThread.Start();
            string ch = string.Empty;
            for (int ss = 0; ss < 3; ss++)
            {
                Thread.Sleep(1000);
                ch = ch + "B";
            }
            //主線程
            textBox1.Text += Thread.CurrentThread.GetHashCode().ToString() + ch + "\r\n";
        }

        private void StartMethod()
        {
            //子線程
            textBox1.Text += Thread.CurrentThread.GetHashCode().ToString() + "CCC" + "\r\n";
            //提交到主線程
            b_Invoke.Invoke(new InvokeDelegate(invokeMethod));
            //子線程
            textBox1.Text += Thread.CurrentThread.GetHashCode().ToString() + "DDD" + "\r\n";
        }

        private void invokeMethod()
        {
            //主線程
            textBox1.Text += Thread.CurrentThread.GetHashCode().ToString() + "EEE" + "\r\n";
        }
        #endregion

        #region BeginInvoke
        Thread bginvokeThread;
        private void b_BeginInvoke_Click(object sender, EventArgs e)
        {
            //主線程
            textBox1.Text += Thread.CurrentThread.GetHashCode().ToString() + "AAA" + "\r\n";
            bginvokeThread = new Thread(new ThreadStart(bgStartMethod));
            bginvokeThread.Start();
            string ch = string.Empty;
            for (int ss = 0; ss < 3; ss++)
            {
                Thread.Sleep(1000);
                ch = ch + "B";
            }
            //主線程
            textBox1.Text += Thread.CurrentThread.GetHashCode().ToString() + ch + "\r\n";
        }

        private void bgStartMethod()
        {
            //子線程
            textBox1.Text += Thread.CurrentThread.GetHashCode().ToString() + "CCC" + "\r\n";
            //提交給主線程
            b_BeginInvoke.BeginInvoke(new InvokeDelegate(bginvokeMethod));
            //子線程
            textBox1.Text += Thread.CurrentThread.GetHashCode().ToString() + "DDD" + "\r\n";
        }

        private void bginvokeMethod()
        {
            //主線程
            textBox1.Text += Thread.CurrentThread.GetHashCode().ToString() + "EEE" + "\r\n";
        }
        #endregion
    }
}
