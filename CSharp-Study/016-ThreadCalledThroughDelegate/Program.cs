using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _016_ThreadCalledThroughDelegate //-p43 theory, -p44 on hand
{
    internal class Program
    {
        //usually we have a thread seperately for methods take longer time to handle (as below)
        static int Test(int i, string str)
        {
            Console.WriteLine("Test! "+i+str);
            Thread.Sleep(100); //pause the thread for 100ms
            return 15;
        }
        static void Main(string[] args) //start a thread in main(from top to bottom)
        {
            //open a thread through delegate
            //Action<int,string> a = Test;
            //Func<int, string, int> func = Test;
            //IAsyncResult funcRes = func.BeginInvoke(5,"lilili",null, null);  //start a new thread to run the method that a delegate
           //IAsyncResult get the thread's current status
            
            Console.WriteLine("main"); //this line and the above one run at the same time (asynchronous execution)

            //1st way to check if the thread ends
            //while (funcRes.IsCompleted == false) //if func thread not completed
            //{
            //    Console.Write(".");
            //    Thread.Sleep(10); //check every 10ms
            //}

            //int funFinalReturn = func.EndInvoke(funcRes); //get the result of the asynchronous thread
            //Console.WriteLine(funFinalReturn);

            //2nd way to check if the thread complete p45
            //wait for 1000ms, if completed>true, if not>false;
            //if complete within 1000ms (700ms for example), then it return true after 700ms
            //bool isComplete = funcRes.AsyncWaitHandle.WaitOne(1000);
            //if (isComplete)
            //{ 
            //    int res=func.EndInvoke(funcRes);
            //    Console.WriteLine(res);
            //}

            //3rd way to check if the thread ends
            Func<int, string, int> func = Test;
            //the second last ref is a delegate called the method it points to when the thread completed
            //the last ref is for providing data for the call back function(the second last ref)
            //IAsyncResult funcRes = func.BeginInvoke(5, "lilili", OnCallBack, func);

            //express it in the lambda expression -p45
            func.BeginInvoke(8, "lilil", funcRes =>
            {
                int res = func.EndInvoke(funcRes);
                Console.WriteLine("In lambda expression - the thread ends with callback: " + res);
            }, null); //the last ref we set null because we can get func directly, no need to pass ref here
            
            Console.ReadKey();
        }
        static void OnCallBack(IAsyncResult funcRes)
        {
            Func<int, string, int> f = (Func<int, string, int>)funcRes.AsyncState;
            //Func<int, string, int> f = funcRes.AsyncState as Func<int, string, int>; //same as above
            int res = f.EndInvoke(funcRes);
            Console.WriteLine("The thread ends with callback: "+res);
        }
    }
}
