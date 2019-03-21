using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Coalescing
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            int? b = a ?? 100;
            Console.WriteLine($">{b}<");
            a = 10;
            b = a ?? 100;
            Console.WriteLine($">{b}<");
            Console.ReadKey();
        }
    }
}
