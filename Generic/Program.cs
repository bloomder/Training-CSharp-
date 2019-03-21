using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class MyClass<T> /// Универсальный  шаблон
    {
        public T field;
        public void Met()
        {
            Console.WriteLine(field.GetType());
        }
    }
    class MyClass2
    {
        public void Method<T>(T arg)
        {
            T s = arg;
            Console.WriteLine($"{s} - {s.GetType()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> m1 = new MyClass<int>();
            m1.Met();
            MyClass<string> m2 = new MyClass<string>();
            m2.field = "";
            m2.Met();
            MyClass2 m3 = new MyClass2();
            m3.Method(123);
            m3.Method("Hello");
            Console.ReadKey();
        }
    }
}
