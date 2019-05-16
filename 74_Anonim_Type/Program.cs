using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74_Anonim_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            var ins = new { Value = 20, Message = "Hello", Count = 2.45 };
            Console.WriteLine(ins.Value + " " + ins.Message + " " + ins.Count);
            object obj = ins;
            Console.ReadKey();
        }
    }
}
