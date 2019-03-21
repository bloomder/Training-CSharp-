using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
{
    class Program
    {
        static int Met(ref int a)
        {
            int b = a * 2;
            a = 20;
            return b;
        }
        static void Method(int a, int b, out int s, out int d)
        {
            s = a + b;
            d = a / b;
        }
        static void Main(string[] args)
        {
            int number = 5;
            int result = Met(ref number);

            int a = 12, b = 2, s, d;
            Method(a, b, out s, out d);
            Console.WriteLine($"a={a}, b={b}, s={s}, d={d}");
            Console.WriteLine(number + " " + result);
            Console.ReadKey();
        }
    }
}
