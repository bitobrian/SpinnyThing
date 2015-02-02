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
                Console.WriteLine(@"\");
                Console.Clear();
                Thread.Sleep(2500);
                Console.WriteLine(@"|");
                Console.Clear();
                Thread.Sleep(2500);
                Console.WriteLine(@"/");
                Console.Clear();
                Thread.Sleep(2500);
                Console.WriteLine(@"-");
                Console.Clear();
                Thread.Sleep(2500);
                Console.WriteLine(@"|");
                Console.Clear();
                Thread.Sleep(2500);
                Console.WriteLine(@"/");
                Console.Clear();
                Thread.Sleep(2500);
                Console.WriteLine(@"-");
                Console.Clear();
                Thread.Sleep(2500);
            }

        }
    }
}
