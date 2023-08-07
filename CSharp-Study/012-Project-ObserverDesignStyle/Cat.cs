using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Project_ObserverDesignStyle
{
    internal class Cat
    {
        private string name;
        private string colour;

        public Cat(string name, string colour)
        {
            this.name = name;
            this.colour = colour;
        }

        //public void CatComing(Mouse m1, Mouse m2)
        public void CatComing()
        {
            Console.WriteLine(colour + " cat is coming! It's " + name);
            //m1.RunAway(); //not good code, not flexible
            //m2.RunAway();

            if (catCome != null)
            {
                catCome(); //trigger the THING
            }
        }
        //public Action catCome;
        public event Action catCome;  //Broadcast the THING
    }
}
