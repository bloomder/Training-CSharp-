using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexator
{
    class MyClass
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        string[] sarr = { "one", "two", "tree", "four", "five" };
        public int this[int index]
        {
            set
            {
                arr[index] = value;
            }
            get
            {
                return arr[index];
            }
        }
        public int this[string index]
        {
            get
            {
                for (int i = 0; i < sarr.Length; i++)
                {
                    if (sarr[i].Equals(index)) { return i; }
                }
                return -1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m1 = new MyClass();
            Console.WriteLine($"{m1[5]}");
            Console.ReadKey();
        }
    }
}
