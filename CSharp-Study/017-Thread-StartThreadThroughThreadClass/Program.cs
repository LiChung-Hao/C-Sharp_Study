using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _017_Thread_StartThreadThroughThreadClass //-p46
{
    internal class Program
    {
        static void DownloadFile(object downloadFileName) //to pass ref in thread >> object type
        {
            Console.WriteLine("With ID: "+Thread.CurrentThread.ManagedThreadId+ downloadFileName+" starts downloading...");
            Thread.Sleep(3000); //wait 3000ms
            Console.WriteLine("Download complete!");
        }
        static void Main(string[] args)
        {
            //Thread t = new Thread(DownloadFile); //create a thread
            //t.Start(" IAmDownloadTarget");//start the thread, pass the ref here

            ////in lambda expression
            ////Thread t = new Thread(() => //if no ref, then just () here
            //Thread t = new Thread(name => //no ref so just () here
            //{
            //    Console.WriteLine("Lambda "+ name+" with ID: " + Thread.CurrentThread.ManagedThreadId + " starts downloading...");
            //    Thread.Sleep(3000); //wait 3000ms
            //    Console.WriteLine("Download complete!");
            //});
            //t.Start("lDownloadTarget");

            //MyFileInfo myFileInfo = new MyFileInfo();
            //myFileInfo.InfoFile("CallOfDuty", "https://cod.com");
            //Thread t = new Thread(myFileInfo.DonwloadFile); //both static method and an object's normal method
            //t.Start();

            //foregraound thread and background thread -p47
            //once the foreground finished, then end the program, close background thread anyway even if not finished
            //*we can set the priority ranking of threads
            Thread t = new Thread(DownloadFile); //default as foreground thread
            t.IsBackground = true; //change it to background thread
            t.Start("COD");

            //t.Abort(); //force to stop the thread
            //t.Join(); //pause/sleep the current thread, wait until t thread finish, then keep running the originally running thread
            Console.WriteLine("Main");
            //Console.ReadKey();
        }
    }
}
