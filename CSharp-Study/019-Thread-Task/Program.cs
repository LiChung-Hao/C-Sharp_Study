using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _019_Thread_Task
{
    //to know more parent thread or consective thread -p50
    internal class Program
    {
        static void ThreadMethod()
        {
            Console.WriteLine("Task starts!");
            Thread.Sleep(3000);
            Console.WriteLine("Task ends!");
        }
        static void Main(string[] args)
        {
            //2 ways to start a task -p49
            ////1.
            //Task t = new Task(ThreadMethod); //pass a method that the thread is gonna run through delegate
            //t.Start();

            //2.
            //TaskFactory tf = new TaskFactory();
            //Task t = tf.StartNew(ThreadMethod); //it will return a task, we can modify it through this task(t)

            Console.WriteLine("Main");
            Console.ReadKey();
        }
    }
}
