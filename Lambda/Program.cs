using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public delegate string MyDel(string s1, string s2);
    class Program
    {
        static void Main(string[] args)
        {
            MyDel m1 = (word1, word2) => word1 + word2;
            Console.WriteLine(m1("Hello ", "World!"));
            Console.ReadKey();
        }
    }
}
