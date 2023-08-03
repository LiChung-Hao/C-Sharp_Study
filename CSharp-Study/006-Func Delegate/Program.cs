using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Func_Delegate //delegate with at least 1 return value
{
    internal class Program
    {
        private static int Test1()
        {
            return 1;
        }
        private static int Test2(string str)
        { 
            Console.WriteLine(str);
            return 50;
        }
        private static int Test3(int i, int j)
        {
            Console.WriteLine("Test3");
            return i + j;
        }
        static void Main(string[] args)
        {
            Func<int> a = Test1; //retrun an int type value
            Func<string, int> b = Test2; //the last one is the return type, others are ref
            Func<int, int, int> c = Test3;

            Console.WriteLine(a());
            b("hi");
            Console.WriteLine(b("hey"));
            c(8, 9);
            Console.WriteLine(c(5, 9));
        }
    }
}
