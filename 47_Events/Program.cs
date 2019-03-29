using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_Events
{
    public delegate void MyDel();
    class MyClass
    {
        public event MyDel myEvent = null;
        public void InvokeEvent()
        {
            myEvent.Invoke();
        }
    }
    class Program
    {
        public static void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }
        public static void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }
        static void Main(string[] args)
        {
            MyClass ins = new MyClass();
            ins.myEvent += MethodOne;
            ins.myEvent += MethodTwo;
            ins.InvokeEvent();

            Console.ReadKey();
        }
    }
}
