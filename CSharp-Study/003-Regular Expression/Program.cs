using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _003_Regular_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string t1 = "I am Li!";
            //string res = Regex.Replace(t1, "^", "Hello! "); //replace the starting point (^)
            //string res2 = Regex.Replace(res, "$", "Au revoir!"); //replace the starting point (^)
            //Console.WriteLine(res);
            //Console.WriteLine(res2);

            //string inp=Console.ReadLine();
            //string pattern = @"^\d*$"; //Starting(^) with zero or multiple(*) numbers(\d) then ends($) >> all are numbers 
            //bool resP=Regex.IsMatch(inp, pattern);
            //Console.WriteLine(resP);

            string s = "I love joana!";
            string pattern = @"[^bdje]"; //it's a char, any char that is not bdje.
            string res = Regex.Replace(s, pattern, "+");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
