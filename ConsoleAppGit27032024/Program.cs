using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppGit27032024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*try
            {
                Propexample obj = new Propexample();

                obj.x_ = 55;
                obj.y_ = 49;

                obj.add();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            /*
            MultiThread obj = new MultiThread();

            Thread t1 = new Thread(obj.m1);
           Thread t2 = new Thread(obj.m2);
            t1.Start();
            t2.Start();
            */

            WordCountWithOutAsync obj = new WordCountWithOutAsync();
            obj.callmethod();
          


        }
    }
}
