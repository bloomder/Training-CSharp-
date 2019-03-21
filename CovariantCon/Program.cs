using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovariantCon
{
    interface IProgrammer
    {
        void Programming();
    }
    class Human : IProgrammer
    {
        public void Sleep()
        {
            Console.WriteLine("Programmer sleeps");
        }
        public void Programming()
        {
            Console.WriteLine("Programmer work");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human[] people = { new Human(), new Human() };
            foreach (Human item in people)
            {
                item.Sleep();
                item.Programming();
            }
            Console.WriteLine(new string('-', 35));
            IProgrammer[] programmers = people;
            foreach (IProgrammer item in programmers)
            {
                item.Programming();
            }
            Console.WriteLine(new string('-', 35));
            people = (Human[])programmers;

        }
    }
}
