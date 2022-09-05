using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void StartMethod()
        {
            //子線程
            MessageBox.Show(Thread.CurrentThread.GetHashCode().ToString() + "CCC");
            //提交到主線程
            b_Invoke.Invoke(new InvokeDelegate(invokeMethod));
            //子線程
            MessageBox.Show(Thread.CurrentThread.GetHashCode().ToString() + "DDD");

        }
    }
}
