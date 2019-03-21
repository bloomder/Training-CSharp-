using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    interface I1
    {
        void Method();
    }
    struct MyStruct : I1
    {
        public void Method()
        {
            Console.WriteLine("Method");
        }
        public int pubint;
        int priint;
        public int Priint { set; get; }
        public MyStruct(int a, int b)// Явное указание конструктора по умолчанию, будет ошибочно
        {
            pubint = a;
            Priint = priint = b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct m1;// будет хранится в стэке
            m1.pubint = 1;
            //m1.Priint = 2;
            //m1.Method();
            MyStruct m2 = new MyStruct();// будет хранится на куче
            m2.pubint = 3;
            m2.Priint = 4;
            m2.Method();
        }
    }
}
