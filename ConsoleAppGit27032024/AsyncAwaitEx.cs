using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGit27032024
{
    internal class AsyncAwaitEx
    {
        public async static  Task<int> Getlenth(string filename)
        {
            int len = 0;
            using (StreamReader reader = new StreamReader(filename))
            {
                string res =await reader.ReadToEndAsync();
                len = res.Length;
                Task.Delay(10000).Wait();
            }

            return len;
        }

        public async void  callmethod()
        {
            string filePath = "C:\\Users\\ADMIN\\Desktop\\dbhefshine.txt";
            Task<int> task = Getlenth(filePath);
            Console.WriteLine(" Other Work 1");
            Console.WriteLine(" Other Work 2");
            Console.WriteLine(" Other Work 3");
            int length = await task;
            Console.WriteLine(" Total length: " + length);
            Console.WriteLine(" After work 1");
            Console.WriteLine(" After work 2");

        }
    }
}
