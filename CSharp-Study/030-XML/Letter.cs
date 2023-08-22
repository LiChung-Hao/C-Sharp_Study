using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_XML
{
    internal class Letter
    {
        public int id { get; set; }
        public string name { get; set; }
        public string from { get; set; }
        public string content { get; set; }

        public override string ToString()
        {
            return string.Format("ID: {0}, NAME: {1}, FROM: {2},MESSAGE: {3}", id, name, from, content);
        }
    }
}
