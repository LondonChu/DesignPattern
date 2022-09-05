using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace InvokeAndBeginInvoke
{
    public partial class Form1 : Form
    {
        //https://iter01.com/427335.html

        public Form1()
        {
            InitializeComponent();
        }

        //1.Control中Invoke，BeginInvoke

        public delegate void InvokeDelegate();
        Thread thread;

        #region Invoke
        private void b_Invoke_Click(object sender, EventArgs e)
        {
            //主線程
            Message("Main Start A");

            thread = new Thread(new ThreadStart(StartMethod));
            thread.Start();

            //string ch = string.Empty;
            //for (int ss = 0; ss < 3; ss++)
            //{
            //    Thread.Sleep(3000);
            //    ch += "B";
            //    Message(ss.ToString());
            //}

            //主線程
            //Message(ch);
            Thread.Sleep(3000);
            Message("Main End C");
        }

        private void StartMethod()
        {
            //子線程
            Message("Thread Start B");
            //提交到主線程
            b_Invoke.Invoke(new InvokeDelegate(iDelegateMethod));
            //子線程
            Message("Thread End F");
        }

        private void iDelegateMethod()
        {
            //主線程
            Message("Invoke Delegate Start D");
            Thread.Sleep(3000);
            Message("Invoke Delegate End E");
        }
        #endregion

        #region BeginInvoke
        private void b_BeginInvoke_Click(object sender, EventArgs e)
        {
            //主線程
            Message("Main Start A");

            thread = new Thread(new ThreadStart(bgStartMethod));
            thread.Start();

            //string ch = string.Empty;
            //for (int ss = 0; ss < 3; ss++)
            //{
            //    Thread.Sleep(3000);
            //    ch += "B";
            //    Message(ss.ToString());
            //}

            ////主線程
            //Message(ch);
            Thread.Sleep(3000);
            Message("Main End C");
        }

        private void bgStartMethod()
        {
            //子線程
            Message("Thread Start B");
            //提交給主線程
            //b_BeginInvoke.BeginInvoke(new Func(()=> {
            //    Message("BeginInvoke Delegate Start D");
            //    Thread.Sleep(3000);
            //    Message("BeginInvoke Delegate End F");
            //}));
            b_BeginInvoke.BeginInvoke(new InvokeDelegate(biDelegateMethod));
            //子線程
            //Thread.Sleep(1000);
            Message("Thread End E");
        }

        private void biDelegateMethod()
        {
            //主線程
            Message("BeginInvoke Delegate Start D");
            Thread.Sleep(3000);
            Message("BeginInvoke Delegate End F");
        }
        #endregion
        
        //2.Delegate中Invokke，BeginInvoke

        public delegate int Add(int a, int b);
        int ExcuteDelegate(int a, int b)
        {
            Message($"Add Start : {a}, {b}");
            Thread.Sleep(5000);
            Message($"Add End : {a}, {b}");
            return a + b;
        }

        #region A.同步呼叫
        private void b_DelegateInvoke_Click(object sender, EventArgs e)
        {
            Add add = new Add(ExcuteDelegate);

            Message("Invoke Start");
            int result = add.Invoke(2, 5);
            Message("Invoke End");
            Message(result.ToString());
        }
        #endregion

        # region B.非同步呼叫
        private void b_DelegateBeginInvoke_Click(object sender, EventArgs e)
        {
            Add add = new Add(ExcuteDelegate);

            Message("BeginInvoke Start");
            IAsyncResult iAsyncResult = add.BeginInvoke(2, 5, null, null);
            Message("BeginInvoke End");
            Message(add.EndInvoke(iAsyncResult).ToString());
        }
        #endregion

        #region C.非同步回撥
        Add add;
        private void b_DelegateBeginInvokeCallBack_Click(object sender, EventArgs e)
        {
            add = new Add(ExcuteDelegate);

            for (int i = 1; i < 10; i++)
            {
                Message($"BeginInvoke Start : {i}");
                add.BeginInvoke(i, 10 * i, MyCallBack, i);
                Message($"BeginInvoke End : {i}");
            }
        }
        private void MyCallBack(IAsyncResult iAsyncResult)
        {
            int result = add.EndInvoke(iAsyncResult);
            Message(result.ToString());
        }
        #endregion

        private void Message(string message)
        {
            //主線程
            Console.WriteLine($"{Thread.CurrentThread.GetHashCode()},{message}");
        }
    }
}
