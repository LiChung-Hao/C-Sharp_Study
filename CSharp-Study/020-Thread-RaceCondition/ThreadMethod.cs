using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_Thread_RaceCondition
{
    internal class ThreadMethod
    {
        private int num = 5;

        public void ChangeNum()
        {
            num++;
            if (num == 5)
            {
                Console.WriteLine("num = 5");
            }
            num = 5;
        }
    }
}
