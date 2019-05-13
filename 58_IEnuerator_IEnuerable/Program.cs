using System;
using System.Collections;

namespace _58_IEnuerator_IEnuerable
{
    class Program
    {
        class MyCollection:IEnumerator,IEnumerable
        {
            int[] array = { 12, 13, 1, 4 };
            int index = -1;

            public object Current { get { return array[index]; } }

            public IEnumerator GetEnumerator()
            {
                return this;
            }

            public bool MoveNext()
            {
                if(index<array.Length-1)
                {
                    index++;
                    return true;
                }
                else { return false; }
            }

            public void Reset()
            {
                index = -1;
            }
        }
        static void Main(string[] args)
        {
            MyCollection ins = new MyCollection();
            foreach (int item in ins)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
