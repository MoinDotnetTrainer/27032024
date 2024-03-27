using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppGit27032024
{
    internal class MultiThread
    {
        public void m1()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i==5)
                {
                    Thread.Sleep(3000);
                }
                Console.WriteLine("m1:"+i);
            }
        }
        public void m2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("m2:" + i);
            }
        }
    }
}
