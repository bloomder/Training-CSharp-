using System;
using System.Threading;

namespace _52_Thread.isBackground
{
    class Program
    {
        // Thread.IsBackground=false; - не фоновый,это значит поток будет жить 
        // независмо от жизни основного потока(Main). Поумолчанию он false
        // Thread.IsBackground=true; - фоновый, это значит, как завершится основной поток(Main)
        // фоновый поток прекратится
        static void Main(string[] args)
        {
            Thread th1 = new Thread(new ThreadStart(Method));
            th1.Start();
            th1.IsBackground = true;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main");
                Thread.Sleep(500);
            }
        }
        static void Method()
        {
            while(true)
            {
                Console.WriteLine("                   Method");
                Thread.Sleep(500);
            }
        }
    }
}
