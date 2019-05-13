namespace _64_Object
{
    class Program
    {
        class MyClass//:Object
        { }
        class MyClasss : object
        {

        }
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.GetHashCode();
            object.Equals(mc, mc);
        }
    }
}
