using System;

namespace NewConstraint
{
    class MyClass<T> where T : new()
    {
        public T instance = new T();
    }
    class Class2
    {
        public int field { get; set; }
        public int field2 { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<Class2> my_in1 = new MyClass<Class2>();
            my_in1.instance.field = 100;
            my_in1.instance.field2 = 200;

            Console.WriteLine($"{my_in1.instance.field}  {my_in1.instance.field2}");
            
            Console.ReadKey();
        }
    }
}
