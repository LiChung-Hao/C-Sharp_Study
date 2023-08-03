using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Action_Delegate //return void only, from System
{
    internal class Program
    {
        private static void PrintString()
        {
            Console.WriteLine("Hello, comment ca va?");
        }
        private static void PrintInt(int i)
        {
            Console.WriteLine("The num is: " + i);
        }
        private static void PrintString(string s)
        {
            Console.WriteLine("The string is: " + s);
        }
        private static void AddTwoInt(int i1, int i2)
        {
            Console.WriteLine("The add res is: "+ (i1+i2));
        }
        static void Main(string[] args)
        {
            Action a = PrintString;
            Action<int> b=PrintInt; //init a delegate b with void return and an int type ref 
            Action<string> c=PrintString; //same method's name >> the system will automatically match which methods to match
            Action<int,int> d= AddTwoInt; //maximum 16 refs, order matters

            a();b(1);c("hey");d(23, 56);
        }
    }
}
