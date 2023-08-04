using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Multicast_Delegate //if there's a return value, it can only get the last method delegated
{
    internal class Program
    {
        static void Test1()
        {
            Console.WriteLine("Test1");
            //throw new Exception(); //if it happens the rest won't run
        }
        static void Test2()
        {
            Console.WriteLine("Test2");
        }
        static void Main(string[] args)
        {
            Action a = Test1;
            a+=Test2;

            //a();
            //a-=Test1;
            //Console.WriteLine("-----------");
            //a();
            //a -= Test2;
            //a(); //if it's empty, then error

            Delegate[] delegates=a.GetInvocationList(); //get all delegates
            foreach (Delegate d in delegates) //walk through
            {
                d.DynamicInvoke(); //run
            }
        }
    }
}
