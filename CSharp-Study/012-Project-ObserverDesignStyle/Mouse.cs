using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Project_ObserverDesignStyle
{
    internal class Mouse
    {
        private string name;
        private string colour;

        public Mouse(string name, string colour, Cat cat)
        {
            this.name = name;
            this.colour = colour;
            cat.catCome += this.RunAway; //register the runaway method into the event in Cat, subscribe the THING
        }

        public void RunAway()
        {
            Console.WriteLine(colour + " mouse runs! " + name + " says: RUN!!");
        }
    }
}
