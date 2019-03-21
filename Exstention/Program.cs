using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exstention
{
    static class MyClass
    {
        public static int ExSum(this int a, int b)
        {
            return a + b;
        }

    }
    class Program
    {        
        static void Main(string[] args)
        {
            int rez = 0;
            rez = rez.ExSum(5);
            rez = rez.ExSum(10);
            Console.WriteLine(rez);
            Console.ReadKey();
        }
    }
}
