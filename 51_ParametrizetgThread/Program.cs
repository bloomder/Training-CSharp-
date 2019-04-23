using System;
using System.Threading;

namespace _51_ParametrizetgThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th1 = new Thread(new ParameterizedThreadStart(Method1));
            th1.Start("Hello");
            th1 = new Thread(new ParameterizedThreadStart(Method1));
            th1.Start("World");
            Console.ReadKey();
        }
        /* ParameterizedThreadStart - только 1 аргумент
        static void Method1(object s, int a)
        {
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(s);
                Thread.Sleep(1000);
            }
        }
        */
        static void Method1(object s)
        {
            for (;;)
            {
                Console.WriteLine(s);
                //Thread.Sleep(1000);
            }
        }
    }
}
