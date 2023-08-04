using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_BubbleExpandOrder
{
    internal class Program
    {
        static void Sort(int[] sortArr)
        {
            bool swapped=true;
            do 
            {
                swapped=false;
                for (int i = 0; i < sortArr.Length - 1; i++)
                {
                    if (sortArr[i] > sortArr[i + 1])
                    {
                        int temp = sortArr[i];
                        sortArr[i] = sortArr[i + 1];
                        sortArr[i + 1] = temp;
                        swapped = true;
                    }                  
                }
            }
            while (swapped);
        }

        static void CommonSort<T>(T[] sortArr, Func<T,T,bool> compareMethod)
        {
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArr.Length - 1; i++)
                {
                    if (compareMethod( sortArr[i] , sortArr[i + 1]))
                    {
                        T temp = sortArr[i];
                        sortArr[i] = sortArr[i + 1];
                        sortArr[i + 1] = temp;
                        swapped = true;
                    }
                }
            }
            while (swapped);
        }
        static void Main(string[] args)
        {
            //int[] sortArr = { 55, 88, 0, 13, 6, 1 };
            //Sort(sortArr);
            //foreach (int i in sortArr)
            //{
            //    Console.WriteLine(i);
            //}

            Employee[] employees = {
            new Employee("alan",500),
            new Employee("blan",00),
            new Employee("clan",800),
            new Employee("dlan",1500),
            new Employee("elan",5300),
            new Employee("flan",50),
            new Employee("glan",5),
            new Employee("hlan",11500),
            };

            CommonSort<Employee>(employees, Employee.Compare);

            foreach (Employee em in employees)
            {
                Console.WriteLine(em); //It will automatically get the tostring method then output
                //Console.WriteLine(em.ToString()); 
            }
        }
    }
}
