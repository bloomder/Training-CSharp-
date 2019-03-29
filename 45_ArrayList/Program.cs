using System;
using System.Collections;
using System.Collections.Generic;

namespace _45_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList my_arrlist = new ArrayList();
            //Boxing
            my_arrlist.Add("Hello");
            my_arrlist.Add(123);
            my_arrlist.Add('q');
            //Unboxing
            foreach (var item in my_arrlist)
            {
                Console.WriteLine(item.ToString());
            }

            List<int> list = new List<int>();
            list.Add(4);
            list.Add(2);
            list.Add(1);
            list.Add(3);
            foreach (int x in list)
            {
                Console.Write($"{x} ");
            }
            list.Sort();Console.WriteLine();
            foreach (int x in list)
            {
                Console.Write($"{x} ");
            }
            list.Reverse(); Console.WriteLine();
            foreach (int x in list)
            {
                Console.Write($"{x} ");
            }
            Console.ReadKey();
        }
    }
}
