using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63_Inner_Exception
{
    class MyClassException
    {
        public void InnerException()
        {
            throw new Exception("Внутреннее исключение");
        }
        public void InnerCatch()
        {
            try
            {
                InnerException();
            }
            catch(Exception e)
            {
                throw new Exception("Внешнее исключение", e);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClassException mce = new MyClassException();
            try
            {
                mce.InnerCatch();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException.Message);
            }
            Console.ReadKey();
        }
    }
}
