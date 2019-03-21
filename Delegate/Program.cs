using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class MyClass
    {
        public void Method()
        {
            Console.Write("Hello ");
        }
    }
    static class MyClass2
    {
        static public void Method2()
        {
            Console.WriteLine("World");
        }
    }
    public delegate void MyDelegate();
    class Program
    {        
        static void Main(string[] args)
        {
            MyClass a1 = new MyClass();
            MyDelegate myD1 = new MyDelegate(a1.Method);
            myD1 += new MyDelegate(MyClass2.Method2);
            myD1();
            Console.ReadKey();
        }
    }
}
