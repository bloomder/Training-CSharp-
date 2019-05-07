using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _54_AnonimMethodThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th1 = new Thread(delegate () { Console.WriteLine("Anonim Method in Thread"); });
            th1.Start();
            th1 = new Thread(delegate (object o) { Console.WriteLine(o); });
            th1.Start("Hello World!!!");
            th1 = new Thread(o => Console.WriteLine(o));
            th1.Start("Lambda metod!!!");
            Console.ReadKey();
        }
    }
}
