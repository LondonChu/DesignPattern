using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine($"Main : {Thread.CurrentThread.GetHashCode()}");
        }

        #region System.Windows.Forms.Timer
        bool b_FormTimer = false;
        private void FormTimer_Tick(object sender, EventArgs e)
        {
            l_FormTimer.BackColor = b_FormTimer?Color.Yellow:Color.Transparent;
            Console.WriteLine($"FormTimer : {Thread.CurrentThread.GetHashCode()}");
            b_FormTimer = !b_FormTimer;
        }

        private void b_FormTimerStart_Click(object sender, EventArgs e)
        {
            FormTimer.Start();//=FormTimer.Enabled = true;
        }

        private void b_FormTimerStop_Click(object sender, EventArgs e)
        {
            FormTimer.Stop();//=FormTimer.Enabled = false;
        }
        #endregion

        #region System.Timers.Timer
        bool b_SystemTimer = false;
        System.Timers.Timer SystemTimer;
        private void b_SystemTimerStart_Click(object sender, EventArgs e)
        {
            SystemTimer = new System.Timers.Timer
            {
                Interval = 100
            };
            SystemTimer.Elapsed += new System.Timers.ElapsedEventHandler(SystemTimer_Tick);


            //SystemTimer.SynchronizingObject = this;//設為同一執行緒


            SystemTimer.Start();
        }

        private void SystemTimer_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            ThreadPool.GetAvailableThreads(out int workerThreads, out int completionPortThreads);
            ThreadPool.GetMinThreads(out int 執行緒集區視需要建立的背景工作執行緒最小數目, out int 執行緒集區視需要建立的非同步IO執行緒最小數目);
            ThreadPool.GetMaxThreads(out int 執行緒集區中的背景工作執行緒最大數目, out int 執行緒集區中的非同步IO執行緒最大數目);
            //Console.WriteLine($"workerThreads : {workerThreads}");
            //Console.WriteLine($"completionPortThreads : {completionPortThreads}");
            //Console.WriteLine($"執行緒集區視需要建立的背景工作執行緒最小數目 : {執行緒集區視需要建立的背景工作執行緒最小數目}");
            //Console.WriteLine($"執行緒集區視需要建立的非同步IO執行緒最小數目 : {執行緒集區視需要建立的非同步IO執行緒最小數目}");
            //Console.WriteLine($"執行緒集區中的背景工作執行緒最大數目 : {執行緒集區中的背景工作執行緒最大數目}");
            //Console.WriteLine($"執行緒集區中的非同步IO執行緒最大數目 : {執行緒集區中的非同步IO執行緒最大數目}");

            Console.WriteLine($"WorkItem Thread : (Busy: {執行緒集區中的背景工作執行緒最大數目- workerThreads}, Free: {workerThreads}, Min: {執行緒集區視需要建立的背景工作執行緒最小數目}, Max: {執行緒集區中的背景工作執行緒最大數目})");
            Console.WriteLine($"IOPC Thread : (Busy: {執行緒集區中的非同步IO執行緒最大數目- completionPortThreads}, Free: {completionPortThreads}, Min: {執行緒集區視需要建立的非同步IO執行緒最小數目}, Max: {執行緒集區中的非同步IO執行緒最大數目})");

            l_SystemTimer.BackColor = b_SystemTimer ? Color.Yellow : Color.Transparent;
            Console.WriteLine($"SystemTimer : {Thread.CurrentThread.GetHashCode()}");
            b_SystemTimer = !b_SystemTimer;
        }

        private void b_SystemTimerStop_Click(object sender, EventArgs e)
        {
            SystemTimer.Stop();
        }
        #endregion

        #region System.Threading.Timer
        bool b_SystemThreadingTimer = false;
        System.Threading.Timer SystemThreadingTimer;
        private void b_SystemThreadingTimerStart_Click(object sender, EventArgs e)
        {
            //Timer(TimerCallback callback[function], object state[開關], int dueTime[等多久開始], int period[隔多久反覆執行])
            SystemThreadingTimer = new System.Threading.Timer(new TimerCallback(SystemThreadingTimer_Tick), ",", 5000, 100);
        }

        private void b_SystemThreadingTimerStop_Click(object sender, EventArgs e)
        {
            SystemThreadingTimer.Dispose();
        }

        private void SystemThreadingTimer_Tick(object state)
        {
            l_SystemThreadingTimer.BackColor = b_SystemThreadingTimer ? Color.Yellow : Color.Transparent;
            Console.WriteLine($"SystemThreadingTimer : {Thread.CurrentThread.GetHashCode()}{state}");
            Thread.Sleep(500);
            b_SystemThreadingTimer = !b_SystemThreadingTimer;
        }
        #endregion
    }
}
