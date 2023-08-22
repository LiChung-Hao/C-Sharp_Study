using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_XML_MorePractice
{
    internal class Letter
    {
        public int id { get; set; }
        public string name { get; set; }
        public string from { get; set; }
        public string favfood { get; set; }
        public string content { get; set; }

        public override string ToString()
        {
            return string.Format("ID: {0}, NAME: {1}, FROM: {2}, FAVFOOD: {3}, MESSAGE: {4}", id, name, from,favfood, content);
        }
    }
}
