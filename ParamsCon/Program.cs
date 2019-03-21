using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsCon
{
    
    class Program
    {
        public static void Method(params int[] s)
        {
            foreach (int item in s)
            {
                Console.Write($"{item}  ");
            }
        }
        static void Main(string[] args)
        {
            int[] d = { 1, 2, 3, 4 };
            int[] s = { 5, 6, 7, 8, 9 };
            int y = 10;
            Method(1,2);
            Console.ReadKey();
        }
    }
}
