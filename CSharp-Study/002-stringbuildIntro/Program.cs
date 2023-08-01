using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; //stringbuilder ref from here
using System.Threading.Tasks;

namespace _002_stringbuildIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string aka System.String

            //three ways to initiate string builder
            //1.
            StringBuilder sb = new StringBuilder("first try!");
            //2.
            StringBuilder sb2 = new StringBuilder(20); //20 is the size of it, it's still empty
            //3. *once length over 20, it will automatically double the size
            StringBuilder sb3=new StringBuilder(@"second \n try",20); //play with @

            sb3.Append(sb);
            sb3.Append(" third");

            Console.WriteLine(sb3);
            Console.WriteLine(sb3.ToString());

            sb3.Insert(1, " inserted ");
            Console.WriteLine(sb3.ToString());

            sb3.Remove(3, 2);
            Console.WriteLine(sb3.ToString());


            sb3.Replace("t", "**");
            Console.WriteLine(sb3.ToString());

            Console.ReadKey();

            //the differenc between string and string builder is str's content can't be changed, sb's can
            // -> sb doesn't need to have new room to edit, more efficient
            // => if we need to frequently modify a string then use sb
        }
    }
}
