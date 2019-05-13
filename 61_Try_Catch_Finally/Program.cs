using System;

namespace _61_Try_Catch_Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 0;
            try
            {
                a = a / b;
                Console.WriteLine($"a = {a}");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Обрабока исключения - " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Работа программы завершена!!!");
            }
            Console.ReadKey();
        }
    }
}
