using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72_Overload_Operators
{
    struct Point
    {
        public int x, y;
        public Point(int a,int b)
        {
            x = a;
            y = b;
        }
        public static Point operator +(Point a, Point b)
        {
            return new Point(a.x + b.x, a.y + b.y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 2);
            Point b = new Point(3, 4);
            Point c = a + b;
            Console.WriteLine($"Point c = {c.x};{c.y}");
            Console.ReadKey();
        }
    }
}
