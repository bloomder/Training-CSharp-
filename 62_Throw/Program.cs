using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62_Throw
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            Exception myExc = new Exception("My Exception!!!");
            try
            {
                if(a==0)
                {
                    throw myExc;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
