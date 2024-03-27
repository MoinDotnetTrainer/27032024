using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGit27032024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Propexample obj = new Propexample();

                obj.x_ = 55;
                obj.y_ = 49;

                obj.add();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         
        }
    }
}
