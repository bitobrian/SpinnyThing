using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Yus
{
    class Program
    {
        static void Main(string[] args)
        {
            bool wut = true;

            while(wut)
            {
                Console.WriteLine("What is your favorite color?");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("NO");
                Thread.Sleep(3000);
                Console.Clear();
            }

        }
    }
}
