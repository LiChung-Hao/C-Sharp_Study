using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_LambadaExpression //a simpler way to replace anominous method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int, int> Add = delegate (int a, int b) //anominous way
            //{//any delegate can use anominous method to give it a value
            //    return (a + b);
            //};

            //Func<int, int, int> Add = (int a, int b) => { return a + b; }; //lambda expression, ref no type required
            //Console.WriteLine(Add(5, 80));

            Func<int, int> PlusOne = a => a + 1; //only 1 ref, ok w/o (). Only 1 sentence, ok w/o {}, or return
            Func<int, int> PlusOne_ = (a) => { return a + 1; }; // same as above          
            Console.WriteLine(PlusOne(55));
            Console.WriteLine(PlusOne_(55));
        }
    }
}
