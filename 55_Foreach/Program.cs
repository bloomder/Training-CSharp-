using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_Foreach
{
    class User
    {
        public string Name { get; }
        public int Age { get; }
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User[] ArrUser = new User[5];
            for (int i = 0; i < ArrUser.Length; i++)
            {
                ArrUser[i] = new User("Robot" + i.ToString(), i + 20);
            }
            foreach (User item in ArrUser)
            {
                Console.WriteLine(item.Name + " - " + item.Age);
            }
            Console.ReadKey();
        }
    }
}
