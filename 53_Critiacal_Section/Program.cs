using System;
using System.Threading;

namespace _53_Critiacal_Section
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            MyClass2 mc2 = new MyClass2();
            for (int i = 0; i < 5; i++)
            {
                new Thread(mc.Method).Start();
                //new Thread(mc2.Method).Start();
                Thread.Sleep(500);
            }
            
            for (int i = 0; i < 5; i++)
            {
                new Thread(mc2.Method).Start();
                Thread.Sleep(500);
            }
            
            Console.ReadKey();
        }
    }

    class MyClass
    {
        public void Method()
        {
            int hashCode = Thread.CurrentThread.GetHashCode();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Поток - {hashCode}, итерация {i}");
                Thread.Sleep(500);
            }
            Console.WriteLine(new string('-', 30));
        }
    }
    class MyClass2
    {
        object valueBlock = new object();
        public void Method()
        {
            int hashCode = Thread.CurrentThread.GetHashCode();
            lock (valueBlock)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Поток - {hashCode}, итерация {i}");
                    Thread.Sleep(500);
                }
                Console.WriteLine(new string('-', 30));
            }
        }
    }
}
