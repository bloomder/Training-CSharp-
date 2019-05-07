using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_Collections
{
    public class User
    {
        string name;
        int id;
        public User(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public string Name { get { return name; } }
        public int Id { get { return id; } }
    }
    public class MyCollection:IEnumerable,IEnumerator
    {
        User[] ArrUser = null;
        Random rand = new Random();
        string[] names = new string[] { "Петя", "Вася", "Оля", "Витя", "Олег", "Наташа", "Семён", "Миша" };
        public MyCollection(int size)
        {
            ArrUser = new User[size];
            Filling();
        }
        int position = -1;
        public void Reset()
        {
            position = -1;
        }
        public bool MoveNext()
        {
            if (position < ArrUser.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public object Current { get { return ArrUser[position]; } }
        public IEnumerator GetEnumerator()
        {
            return this as IEnumerator;
        }
        void Filling()
        {
            for (int i = 0; i < ArrUser.Length; i++)
            {
                ArrUser[i] = new User(names[rand.Next(0, names.Length - 1)], rand.Next(0, 1000));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection mc = new MyCollection(10);
            foreach (User item in mc)
            {
                Console.WriteLine(item.Id + " - " + item.Name);
            }
            Console.ReadKey();
        }
    }
}
