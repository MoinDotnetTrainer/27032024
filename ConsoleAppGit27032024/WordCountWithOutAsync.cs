using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGit27032024
{
    internal class WordCountWithOutAsync
    {
        public static int Getlenth(string filename)
        {
            int len = 0;
            using (StreamReader reader= new StreamReader(filename))
            {
                string res = reader.ReadToEnd();
                len = res.Length;
                Task.Delay(10000).Wait();
            }

            return len;
        }

        public void callmethod()
        {
            string filname = "C:\\Users\\ADMIN\\Desktop\\dbhefshine.txt";
            int currlen = Getlenth(filname);
            Console.WriteLine("task 1");
            Console.WriteLine("task 2");
            Console.WriteLine("task 3");

            Console.WriteLine("lenth of the file is:"+currlen);

            Console.WriteLine("task 4");
            Console.WriteLine("task 5");
            Console.WriteLine("task 6");

        }
    }
}
