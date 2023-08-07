using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _013_LinQ
{
    internal class MarticalArt
    {
        public string Name { get; set; }
        public string Menpai { get; set; }
        public string Kungfu { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public int Level { get; set; }

        public override string ToString()
        {
            return String.Format("Id: {0},Name: {1},Age: {2},Menpai: {3},Kungfu: {4},Level: {5}", Id, Name, Age, Menpai,Kungfu, Level);
        }
    }
}
