using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _73_Explicit_Implicit
{
    struct MyStruct
    {
        public int x;
        public MyStruct(int a)
        {
            x = a;
        }
        public static explicit operator MyStruct(int a)
        {
            MyStruct ms = new MyStruct(a);
            return ms;
        }
    }
    struct MyStruct2
    {
        public int x;
        public MyStruct2(int a)
        {
            x = a;
        }
        public static implicit operator MyStruct2(int a)
        {
            MyStruct2 ms = new MyStruct2(a);
            return ms;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            MyStruct myStruct = (MyStruct)a;
            Console.WriteLine(myStruct.x);
            a = 124;
            MyStruct2 myStruct2 = (MyStruct2)a;
            Console.WriteLine(myStruct2.x);

            Console.ReadKey();
        }
    }
}
