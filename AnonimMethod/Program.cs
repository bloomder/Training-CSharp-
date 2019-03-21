using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonimMethod
{
    public delegate string MyDel(string s1, string s2);

    class Program
    {
        static void Main(string[] args)
        {
            MyDel m1 = delegate (string s1, string s2) { return s1 + s2; };
            string s = null;
            s = m1("Hello", " World");
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
