using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_AddRemoveEvent
{
    public delegate void MyDel();
    class MyClass
    {
        MyDel MyEvent = null;
        public event MyDel myEvent
        {
            add
            {
                MyEvent += value;
                Console.WriteLine($"Add handler - {value.Method.Name}");
            }
            remove
            {
                MyEvent -= value;
                Console.WriteLine($"Remove handler - {value.Method.Name}");
            }
        }
        public void InvokeClass()
        {
            MyEvent.Invoke();
        }
    }
    class Program
    {
        static void Handler1()
        {
            Console.WriteLine("Handler1");
        }
        static void Handler2()
        {
            Console.WriteLine("Handler20");
        }
        static void Main(string[] args)
        {
            MyClass ins = new MyClass();
            ins.myEvent += Handler1;
            ins.myEvent += Handler2;
            Handler2();
            Console.ReadKey();
        }
    }
}
