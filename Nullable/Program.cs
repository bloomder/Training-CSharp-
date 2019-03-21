using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> x = null;
            int? a = null;
            int? b = a + 5;
            Console.WriteLine($">{b}<");
            Console.ReadKey();
        }
    }
}
