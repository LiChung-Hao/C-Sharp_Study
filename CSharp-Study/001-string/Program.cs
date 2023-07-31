using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---1. basic string -> length method / string info---
            //string s = "First string";
            //int length=s.Length;
            ////Console.WriteLine(length);


            //s = "updated string " + s;
            ////string is an unchangable type of data. here i created a new string and update what s points to

            //char c = s[3];
            //Console.WriteLine(s);
            ////Console.WriteLine(c);

            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.WriteLine(s[i]);
            //}

            //---2. more string methods
            string s = " test1.abc.def";
            string t_wrong1 = "test2";
            string t_wrong2 = "test0";
            string t_right = "test1";

            //CompareTo return an int >>right 0; wring >0 or <0
            //int w1 =s.CompareTo(t_wrong1); //check each space, smaller -1
            //int w2 =s.CompareTo(t_wrong2); // check each space, bigger +1
            //int r=s.CompareTo(t_right);

            //Console.WriteLine(w1);
            //Console.WriteLine(w2);
            //Console.WriteLine(r);

            //Replace
            //string newS = s.Replace('t', 'a'); //replace all t(s) in s to a
            //Console.WriteLine(newS);
            //Console.WriteLine(s); //won't change the original one

            //Split
            //string[] sep=s.Split('.'); //the signal "cut from here"
            //foreach (string temp in sep)
            //{ 
            //    Console.WriteLine(temp);
            //}

            //Substring
            //string subS=s.Substring(2, 5); //starting from location 2 to 5 space after it
            //Console.WriteLine(subS);
            //Console.WriteLine(s); //won't change the original one

            //ToUpper
            //string sUpper = s.ToUpper();
            //Console.WriteLine(sUpper);

            //Trim
            //string sTrim = s.Trim();
            //Console.WriteLine(sTrim); //remove the blank space at front and end
            //Console.WriteLine(s);

            //IndexOf
            //int index = s.IndexOf("eas"); //if doesn't exist, return -1; if does, return the index of it
            //Console.WriteLine(index);

            Console.ReadLine();
        }
    }
}
