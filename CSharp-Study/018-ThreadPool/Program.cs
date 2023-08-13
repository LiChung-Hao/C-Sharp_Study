using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _018_ThreadPool //Default as background, can't be changed to foreground -p48
    //better used in a short-period / small task, if we need it run constantly (like spell check function)
    //then we should create a Thread class for that
{
    internal class Program
    {
        static void ThreadMethod(object state)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId+" thread begins!");
            Thread.Sleep(3000);
            Console.WriteLine("Thread ends!");
        }
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(ThreadMethod); //the method here has to have at least one ref, so we have state in the method
            ThreadPool.QueueUserWorkItem(ThreadMethod); //start a thread
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);

            Console.ReadKey();
        }
    }
}
