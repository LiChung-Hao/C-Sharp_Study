using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Event
{
    internal class Program
    {
        public delegate void MyDelegate();
        //public MyDelegate myDelegate; //a delegate var as a member in class Program
        public event MyDelegate myDelegate; //a delegate var as a member in class Program in event>>same result
        static void Main(string[] args)
        {
            Program program = new Program();
            program.myDelegate = Test1;
            program.myDelegate();
        }
        
        static void Test1()
        {
            Console.WriteLine("Test1");
        }
            

    }
}
