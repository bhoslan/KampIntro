using System;
using System.Collections.Generic;

namespace GenericsOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Elazığ");
            Console.WriteLine(sehirler2.Count);
        }
    }

    class MyList<T>
    {
        public MyList()
        {
            array = new T[0];
        }
        T[] tempArray;
        T[] array;
        
        public void Add(T item)
        {
            tempArray = array;
            array = new T[array.Length + 1];
            
            for (int i = 0; i < tempArray.Length; i++)
            {
                array[i] = tempArray[i];
            }

            array[array.Length - 1] = item;
        }


        public int Count
        {
            get { return array.Length; }
        }

    }
}
