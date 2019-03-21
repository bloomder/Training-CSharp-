namespace PartialMethod
{
    partial class PartClass1
    {
        public PartClass1()
        {

        }
        partial void MethodOne();
        partial void Sum(int x, int y)
        {

        }
    }
    partial class PartClass1
    {
        partial void MethodOne()
        {
        }
        partial void Sum(int x, int y);
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
