using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraint
{
    // Работа ограничения параметров типа
    class MyFirstClass<T> where T : class
    {
        public T variable;
    }
    class MySecondClass<T> where T : struct
    {
        public T variable;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyFirstClass<string> in1 = new MyFirstClass<string>();
            //MyFirstClass<int> in2 = new MyFirstClass<int>(); только T ссылочные типы.
            MySecondClass<int> in2 = new MySecondClass<int>();
            //MySecondClass<string> in3 = new MySecondClass<string>(); только T структурные типы.

        }
    }
}
