using System;
using System.Threading;

namespace _50_Thread
{
    class Program
    {
        static void Method()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method: " + i.ToString());
                //Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Thread th1 = new Thread(new ThreadStart(Method));
            th1.IsBackground = true;
            th1.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main: " + i.ToString());
                //Thread.Sleep(1000);
            }
            Console.ReadKey();
        }
    }
}
