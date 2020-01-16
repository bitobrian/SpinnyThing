using System;
using System.Threading;

namespace SpinnyThing
{
    class Program
    {
        static void Main(string[] args)
        {
            int spinSpeed = 75;
            while (true)
            {
                Console.WriteLine(@"\");
                Thread.Sleep(spinSpeed);
                Console.Clear();

                Console.WriteLine(@"|");
                Thread.Sleep(spinSpeed);
                Console.Clear();

                Console.WriteLine(@"/");
                Thread.Sleep(spinSpeed);
                Console.Clear();

                Console.WriteLine(@"-");
                Thread.Sleep(spinSpeed);
                Console.Clear();
            }
        }
    }
}
