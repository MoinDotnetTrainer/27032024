using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGit27032024
{
    internal class Propexample
    {
        private int x;

        public int x_
        {
            get { return x; }
            set
            {
                if (value > 50 )
                {
                    throw new ArgumentException( "value cannit be greater than 50" ); 
                }
                else
                {
                    x = value;
                }
            }
        }

        private int y;

        public int y_
        {
            get { return y; }
            set { y = value; }
        }

        public void add()
        {
            int z = x + y;
            Console.WriteLine("Add is:" + z);
        }


    }
}
