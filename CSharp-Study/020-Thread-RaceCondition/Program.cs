using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _020_Thread_RaceCondition // -p51
{
    internal class Program
    {
        static void ChangeNumHere(object o)
        {
            ThreadMethod threadMethod = o as ThreadMethod;
            while (true)
            {
                // we have to set the order of lock at the beginning of coding to avoid dead lock
                lock (threadMethod) //require sys to lock the thread if it's not locked
                {
                    threadMethod.ChangeNum(); //so only one thread can run this method
                }//release the lock (unlock it)
            }
        }
        static void Main(string[] args)
        {
            ThreadMethod tm = new ThreadMethod();
            Thread t = new Thread(ChangeNumHere);
            t.Start(tm);

            Thread newT= new Thread(ChangeNumHere); //start a new thread
            newT.Start(tm);

            Console.ReadKey();
        }
    }
}
