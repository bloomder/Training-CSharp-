using System;

namespace _60_Try_Catch
{
    class Program
    {
        static int a = 1, b = 0;
        static void Main(string[] args)
        {
            try
            {
                a = a / b;
                Console.WriteLine($"a = {a}");
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
