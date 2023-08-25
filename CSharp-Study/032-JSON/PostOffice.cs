using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _032_JSON
{
    internal class PostOffice
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int SeriesNumber { get; set; }
        public List<Letter> Task { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, Country: {1}, Series Number: {2}, Task: ", Name, Country, SeriesNumber);
        }
    }
}
