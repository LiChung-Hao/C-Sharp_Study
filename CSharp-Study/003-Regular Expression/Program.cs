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

            //string s = "I love joana!";
            //string pattern = @"[^bdje]"; //it's a char, any char that is not bdje.
            //string res = Regex.Replace(s, pattern, "+");
            //Console.WriteLine(res);

            //Repeat 
            //string qq1 = "123456";
            //string qq2 = "123456123456789";
            //string qq3 = "a123456123456789";
            //string pattern = @"^\d{5,12}$";
            //string pattern1 = @"\d{5,12}"; //as long as it has it
            //Console.WriteLine(Regex.IsMatch(qq1,pattern));
            //Console.WriteLine(Regex.IsMatch(qq2,pattern));
            //Console.WriteLine(Regex.IsMatch(qq3,pattern));
            //Console.WriteLine(Regex.IsMatch(qq3,pattern1));
            //Console.WriteLine(Regex.IsMatch(qq3,pattern1));
            //Console.WriteLine(Regex.IsMatch(qq3,pattern1));

            //or
            //string s = "12 @@!&.bd5_哈哈A";
            //string pattern = @"\d|[a-z]";
            //MatchCollection matchCollection = Regex.Matches(s, pattern);
            //foreach (Match match in matchCollection)
            //{
            //    Console.WriteLine(match);
            //}

            //string s = @"lichung,wuannie;joanabb.vanuaaluna-hhaws";
            ////string pattern = @"[,;.-]"; //one of these four
            //string pattern = @"[,]|[;]|[.]|[-]"; //one of these four
            //string[] resArr = Regex.Split(s, pattern);
            //foreach (string str in resArr)
            //{ 
            //    Console.WriteLine(str);
            //}

            //string inp=Console.ReadLine();
            //string keys = @"(ab\w{2}){2}";//==ab\w\wab\w\w
            //Console.WriteLine( Regex.Replace(inp, keys, "R"));

            //ipv4 check 0-255.0-255.0-255.0-255
            //string ip=Console.ReadLine();
            //string pattern = @"^((25[0-5]|2[0-4]\d|[01]?\d\d?)\.){3}(25[0-5]|2[0-4]\d|[01]?\d\d?)$";
            //Console.WriteLine(Regex.IsMatch(ip, pattern));


            Console.ReadKey();
        }
    }
}
