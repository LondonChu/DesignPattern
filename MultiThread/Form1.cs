using System;
using System.Threading;
using System.Windows.Forms;

namespace MultiThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //A.多執行續如何更新UI,如何跨UI
            Thread threadA = new Thread(ChangeThread);
            threadA.Start();

            //B.三種多執行續用法
            //1.lock : 
            Thread t1B1 = new Thread(LockWC);
            t1B1.Start();
            Thread t2B1 = new Thread(LockWC);
            t2B1.Start();
            Thread t3B1 = new Thread(LockWC);
            t3B1.Start();
            Console.Read();
            //2.Monitor : 
            Thread t1B2 = new Thread(MonitorWC);
            t1B2.Start();
            Thread t2B2 = new Thread(MonitorWC);
            t2B2.Start();
            Thread t3B2 = new Thread(MonitorWC);
            t3B2.Start();
            Console.Read();
            //3.Mutex :
            Thread t1B3 = new Thread(MutexWC);
            t1B3.Start();
            Thread t2B3 = new Thread(MutexWC);
            t2B3.Start();
            Thread t3B3 = new Thread(MutexWC);
            t3B3.Start();
            Console.Read();
            Thread threadB1 = new Thread(new ThreadStart(thread1Func));
            threadB1.Start();
            Thread threadB2 = new Thread(new ThreadStart(thread2Func));
            threadB2.Start();
        }

        private void ChangeThread()
        {
            UpdateString("textBox", textBox);
        }

        //A.多執行續如何更新UI,如何跨UI
        private delegate void UIDelegate(string s, Control c);
        private void UpdateString(string s, Control c)
        {
            if (c.InvokeRequired)
            {
                c.Invoke(new UIDelegate(UpdateString), s, c);
            }
            else
            { 
                c.Text = s;
            }
        }

        //B.三種多執行續用法
        private static object obj = new object();

        //1.lock : 陳述式會取得指定物件的互斥鎖定、執行陳述式區塊，然後釋放鎖定。 持有鎖定時，持有鎖定的執行緒可以再次取得並釋放鎖定。 其他執行緒將無法取得鎖定，並將等待直到釋放鎖定為止。
        private void LockWC()
        {
            lock (obj)
            {
                Console.WriteLine($"小{Thread.CurrentThread.GetHashCode()} : 拉了第1坨屎");
                Thread.Sleep(100);
                Console.WriteLine($"小{Thread.CurrentThread.GetHashCode()} : 拉了第2坨屎");
            }
        }

        //2.Monitor : Monitor可實現lock所有功能，Monitor有TryEnter可以傳入等待逾時時間的功能，可以防止出現死鎖的問題，lock没有。
        private void MonitorWC()
        {
            if (Monitor.TryEnter(obj, 1000))
            {
                try
                {
                    Console.WriteLine($"小{Thread.CurrentThread.GetHashCode()} : 拉了第1坨屎");
                    Thread.Sleep(100);
                    Console.WriteLine($"小{Thread.CurrentThread.GetHashCode()} : 拉了第2坨屎");
                }
                finally
                {
                    Monitor.Exit(obj);
                }
                //return true;
            }
            else
            {
                //return false;
            }
        }

        //3.Mutex : 在不同Process之間，同一時間內只授予一個Thread在共享資源的獨佔訪問。Mutex可實現Monitor所有功能，可跨process，lock和Monitor不行。
        private static Mutex mutex = new Mutex();
        private void MutexWC()
        {
            Console.WriteLine($"{Thread.CurrentThread.GetHashCode()} is in WC.");

            if (mutex.WaitOne(1000))
            {
                Console.WriteLine($"{Thread.CurrentThread.GetHashCode()} is 拉屎 ing.");
                Thread.Sleep(50);
                Console.WriteLine($"{Thread.CurrentThread.GetHashCode()} is 拉屎 end.");
                mutex.ReleaseMutex();
                Console.WriteLine($"{Thread.CurrentThread.GetHashCode()} is out WC.");
            }
        }

        private void thread1Func()
        {
            for (int count = 0; count < 10; count++)
            {
                mutex.WaitOne();
                TestFunc("Thread1 have run " + count.ToString() + " times");
                Thread.Sleep(3000);
                mutex.ReleaseMutex();
            }
        }

        private void thread2Func()
        {
            for (int count = 0; count < 10; count++)
            {
                mutex.WaitOne();
                TestFunc("Thread2 have run " + count.ToString() + " times");
                mutex.ReleaseMutex();
            }
        }

        private void TestFunc(string str)
        {
            Console.WriteLine("{0} {1}", str, System.DateTime.Now.Millisecond.ToString());
            Thread.Sleep(50);
        }
    }
}
