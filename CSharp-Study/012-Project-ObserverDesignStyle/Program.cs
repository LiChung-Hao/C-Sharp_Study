using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Project_ObserverDesignStyle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Hao", "Orange");

            ////not good code, not flexible
            //Mouse m1 = new Mouse("Micky", "Gray");
            //Mouse m2 = new Mouse("Ticky", "Green");
            ////cat.CatComing(m1, m2); 


            Mouse m1 = new Mouse("Micky", "Gray", cat);
            //cat.catCome += m1.RunAway;
            Mouse m2 = new Mouse("Ticky", "Green",cat);
            //cat.catCome += m2.RunAway;
            //cat.catCome(); //event can't be called outside of the class; only inside
            cat.CatComing();
        }
    }
}
