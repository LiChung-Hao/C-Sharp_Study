#define IsDefine //the syntax of define; should be written before using xxx

using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _015_Attribution 
{
    [MyTest("A simple attribute", VersionNum ="VSnum", Id =5)] //the attribution part is not necessary. (it was MyTestAttribution)
    //we can see it as call the structure method in this attribute, we can give default value to the var in it
    internal class Program
    {
        //Obsolete
        //it's been dicarded completely, and can't be used, error message block
        [Obsolete("Don't use it, use NewMethod!",true)]
        static void TooOldMethod()
        {
            Console.WriteLine("TooOldMethod");
        }
        //obsolete means it's been discarded, but still can be used, the string after is a reminder message in warning message block
        [Obsolete("It's out of date, use NewMethod instead")] 
        static void OldMethod()
        {
            Console.WriteLine("OldMethod");
        }
        static void NewMethod()
        {
            Console.WriteLine("NewMethod");
        }

        //Conditional
        [Conditional("IsDefine")] //only can be called once IsDefine is defined (check line1); no matter what, it will be compiled into Assembly
        static void Test1()
        {
            Console.WriteLine("Test1");
        }
        static void Test2()
        {
            Console.WriteLine("Test2");
        }

        //Caller info
        [DebuggerStepThrough] //the compiler skip the debugging part in this method, just run it. only use it when we are sure there is no bug inside it
        static void PrintString(string str,[CallerFilePath] string callerFileName="",[CallerLineNumber] int lineNum=0, [CallerMemberName]string whoCallMethod="")
        {
            Console.WriteLine(str);
            Console.WriteLine(callerFileName);
            Console.WriteLine(lineNum);
            Console.WriteLine(whoCallMethod);
        }
        static void Main(string[] args)
        {
            //Obsolete -p38
            //OldMethod();
            //TooOldMethod(); //blocking error

            //Conditional -p39
            //Test1();
            //Test1();
            //Test2();
            //Test1();

            //Caller info - p40
            //PrintString("I love C-sharp");
            //Console.WriteLine("next line");

            //Custom attribute -p42
            Type type = typeof(Program); //Get the type object through typeof + class name
            object[] objs = type.GetCustomAttributes(false); //false here means no return it's ancesstor's attribute
            MyTestAttribute attr = (MyTestAttribute)objs[0]; //only one attribute, so here objs[0] is MyTestAttribute
            Console.WriteLine(attr.Id);
            Console.WriteLine(attr.Description);

            Console.ReadKey();
        }
    }
}
