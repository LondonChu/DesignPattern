using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskRun
{
    public class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.GetMaxThreads(out int workThreads, out int completionPortThreads);
            Console.WriteLine($"{workThreads} {completionPortThreads}");

           ShowThreadInfo("=主執行緒開始=");

            var task1 = Task.Run(() => OCVACRModual("第1套"));
            var task2 = Task.Run(() => OCVACRModual("第2套"));
            var task3 = Task.Run(() => OCVACRModual("第3套"));
            var task4 = Task.Run(() => OCVACRModual("第4套"));
            var task5 = Task.Run(() => OCVACRModual("第5套"));
            var task6 = Task.Run(() => OCVACRModual("第6套"));

            ShowThreadInfo("=主執行緒結束=");
            Console.ReadLine();
        }

        static void OCVACRModual(string s)
        {
            ShowThreadInfo($"{s} 開始量測");

            for (int i = 0; i < 10; i++)
            {
                ShowThreadInfo($"{s} 切{i.ToString().PadLeft(2, '0')}通道");

                var taskACR = Task.Run(() => Measure($"{s} ACR = {i.ToString().PadLeft(2, '0')}"));
                var taskOCV = Task.Run(() => Measure($"{s} OCV = {i.ToString().PadLeft(2, '0')}"));
                var taskPSV = Task.Run(() => Measure($"{s} PSV = {i.ToString().PadLeft(2, '0')}"));
                var tasks = new Task[3] { taskOCV, taskACR , taskPSV };
                Task.WaitAll(tasks);
            }

            ShowThreadInfo($"{s} 結束量測");
        }

        static void ShowThreadInfo(string s)
        { 
            ThreadPool.GetAvailableThreads(out int workerThreads, out int portThreads);
            Console.WriteLine("{0} thread ID : {1}, task ID : {2}, time : {3}:{4}, Available worker threads : {5}, Available completion port threads: {6}", s, 
                Thread.CurrentThread.GetHashCode().ToString().PadLeft(2,'0'), 
                Task.CurrentId.ToString().PadLeft(2, '0'), 
                DateTime.Now.Second,DateTime.Now.Millisecond, workerThreads, portThreads);
        }

        static void Measure(string s)
        {
            ShowThreadInfo(s);
            Thread.Sleep(100);
        }
    }
}
