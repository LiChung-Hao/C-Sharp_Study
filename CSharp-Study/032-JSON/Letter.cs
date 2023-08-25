using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_JSON
{
    internal class Letter
    {
        public string name { get; set; }
        public string message { get; set; }
        public int id { get; set; }

        public override string ToString()
        {
            return string.Format("ID: {0}, NAME: {1}, MESSAGE: {2}", id, name, message);
        }
    }
}
