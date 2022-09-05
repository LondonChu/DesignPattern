using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestThreadPool();
            Console.ReadKey();
        }



        static void TestThreadPool()
        {
            //for (int i = 0; i < 500; i++)
            //{
            //    int i1 = i;
            //    ThreadPool.QueueUserWorkItem((state) =>
            //    {
            //        Console.WriteLine("{0} on thread {1}", i1, Thread.CurrentThread.ManagedThreadId);
            //        Thread.Sleep(500000);
            //    });
            //}



            for (int i = 0; i < 500; i++)
            {
                int i1 = i;
                Task.Run(() => Test(i1));
            }
        }



        static void Test(int i1)
        {
            //Console.WriteLine("{0} on thread {1}", i1, Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine($"{i1} on thread {Thread.CurrentThread.ManagedThreadId} \t {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")} ");
            Thread.Sleep(500);
        }
    }
}
