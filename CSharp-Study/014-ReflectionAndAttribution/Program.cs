using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _014_ReflectionAndAttribution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////every class correspond to a type. This type store info of data and data member in this class
            //MyClass myClass = new MyClass(); //MyClass store the member; myClass store the value
            //Type type = myClass.GetType(); //get the type through the myClass object
            //Console.WriteLine(type.Name);
            //Console.WriteLine(type.Namespace);
            //Console.WriteLine(type.Assembly);

            //Console.WriteLine("\n\nField Info");
            //FieldInfo[] fieldInfos = type.GetFields(); //it can get public variable members
            //foreach (FieldInfo fieldInfo in fieldInfos)
            //{
            //    Console.Write(fieldInfo.Name + " ");
            //}

            //Console.WriteLine("\n\nProperty Info");
            //PropertyInfo[] propertyInfos=type.GetProperties();
            //foreach (PropertyInfo propertyInfo in propertyInfos)
            //{
            //    Console.Write(propertyInfo.Name + " ");
            //}

            //Console.WriteLine("\n\nMethod Info");
            //MethodInfo[] methodInfos = type.GetMethods();
            //foreach (MethodInfo methodInfo in methodInfos)
            //{
            //    Console.Write(methodInfo.Name + " ");
            //}

            ////Summary: We can get the member info in a class through type -p36
            
            //Assembly - p37
            MyClass myClass=new MyClass();
            Assembly assembly = myClass.GetType().Assembly; //get assembly throguh type object
            Console.WriteLine(assembly.GetName().Name);
            Console.WriteLine(assembly.FullName);
            Type[] types = assembly.GetTypes();
            foreach (Type t in types)
            {
                Console.WriteLine(t);
            }
        }
    }
}
