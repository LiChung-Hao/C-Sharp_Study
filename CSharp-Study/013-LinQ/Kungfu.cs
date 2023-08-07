using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_LinQ
{
    internal class Kungfu
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public int K_Id { get; set; }

        public override string ToString()
        {
            return String.Format("Name: {0}, Power: {1}, K_id: {2}", Name, Power, K_Id);
        }
    }
}
