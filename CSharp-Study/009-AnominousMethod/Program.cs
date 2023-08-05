using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_AnominousMethod
{
    internal class Program
    {
        static int Test1(int a, int b)
        { 
            return a + b;
        }
        static void Main(string[] args)
        {
            //Func<int, int, int> Add = Test1; //normal way

            Func<int, int, int> Add = delegate (int a, int b) //anominous way
            {//any delegate can use anominous method to give it a value
                return (a + b);
            };
        }
    }
}
