using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_DelegateIntro
{
    internal class Program
    {
        private delegate string GetAString(); //define a delegate
        private delegate void PrintString();
        static void Main(string[] args)
        {
            //1.
            //int x = 40;
            ////string s=x.ToString();
            ////GetAString a = new GetAString(x.ToString); //a points to the tostring method from x
            //GetAString a = x.ToString; //same as above

            ////string s = a(); //get tostring method through delegate a
            //string s = a.Invoke();//Using method invoke to get the method a ref use 


            //Console.WriteLine(s);//call a method through delegate or call a method directly are the same

            //2.
            PrintString a=Method1;
            PrintStr(a);
            a=Method2;
            PrintStr(a);
            
            Console.ReadKey();
        }

        static void PrintStr(PrintString print)
        {
            print();
        }

        static void Method1()
        {
            Console.WriteLine("Method1");
        }
        static void Method2()
        {
            Console.WriteLine("Method2");
        }
    }
}
