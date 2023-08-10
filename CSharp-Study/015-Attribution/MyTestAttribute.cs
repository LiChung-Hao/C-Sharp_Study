using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Attribution
{
    //1. The name should end with "Attribute"
    //2. It inherit from system.attribute
    //3. Sealed >> not be inherited by other
    //4. Usually express the structure of target object(some variable or attribute usually not method)
    [AttributeUsage(AttributeTargets.Class)]//means this attribute can be used in class
    internal sealed class MyTestAttribute:System.Attribute
    {
        public string Description { get; set; }
        public string VersionNum { get; set; }
        public int Id { get; set; }

        public MyTestAttribute(string des)
        { 
            this.Description = des;
        }
    }
}
