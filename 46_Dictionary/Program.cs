using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDic = new Dictionary<int, string>();
            myDic.Add(0, "Zero");
            myDic.Add(1, "One");
            myDic.Add(2, "Two");
            myDic.Add(3, "Three");
            foreach (var item in myDic)
            {
                Console.Write($"{item.Key}-{item.Value}  ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
