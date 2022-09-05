using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ThreadPool.SetMinThreads(5, 5);  //設定最小執行緒數為5個
            //ThreadPool.SetMaxThreads(15, 15);  //設定最大執行緒數為15個，這兩個方法要配合使用才能控制執行緒數量
            //int workerThread2s;
            //int portThread2s;



            //ThreadPool.GetAvailableThreads(out workerThread2s, out portThread2s);



            //Console.WriteLine("\nAvailable worker threads: \t{0}" +
            //     "\nAvailable completion port threads: {1}",
            //     workerThread2s, portThread2s);
            //Thread.Sleep(5000);




            int i1 = 1;
            while (true)
            {
                i1 += 1;
                Task.Run(() => Test(i1));




                int workerThreads;
                int portThreads;



                ThreadPool.GetAvailableThreads(out workerThreads, out portThreads);



                Console.WriteLine("\nAvailable worker threads: \t{0}" +
                     "\nAvailable completion port threads: {1}",
                     workerThreads, portThreads);




                Thread.Sleep(500);



            }
        }
        static void Test(int i1)
        {
            //Console.WriteLine("{0} on thread {1}", i1, Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine($"{i1} on thread {Thread.CurrentThread.ManagedThreadId} \t {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")} ");
            Thread.Sleep(500000);
        }
    }
}
