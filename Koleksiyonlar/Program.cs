using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //String[] isimler = new String[] {"A","B","C","D" };

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler = new string[5];
            //isimler[4] = "E";

            List<string> isimler2 = new List<string> {"A","B","C","D" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("E");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            int a = isimler2.Count;
            Console.WriteLine(a);
            
        }
    }
}
