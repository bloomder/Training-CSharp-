using System;

namespace Enums
{
    enum MyEnumType
    {
        one = 1,
        two = 2,
        three = 3,
        four = 4
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)MyEnumType.one);
            Console.ReadKey();
        }
    }
}
