using System;
using System.Collections;
using System.Collections.Generic;

namespace _57_Yield
{
    class Program
    {
        static List<int> myList = new List<int>();
        static void Fill()
        {
            for (int i = 0; i < 10; i++)
            {
                myList.Add(i);
            }            
        }
        static void Main(string[] args)
        {
            Fill();
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 30));
            foreach (int item in Method())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("myList");
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 30));

            foreach (int item in Method2())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("myList");
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 30));


            Console.ReadKey();
        }
        static List<int> Method()
        {
            List<int> temp = new List<int>();
            foreach (int item in myList)
            {
                if(item>2)
                {
                    temp.Add(item);
                }
            }
            return temp;
        }
        static IEnumerable Method2()
        {
            foreach (int item in myList)
            {

                if (item == 8)
                {
                    yield break;
                }
                if (item >2)
                {
                    yield return item;
                }
            }
        }
    }
}
