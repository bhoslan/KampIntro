using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> openWith = new Dictionary<string, string>() ;
            //openWith.Add("txt", "notepad.exe");
            //openWith.Add("bmp", "paint.exe");
            //openWith.Add("dib", "paint.exe");
            //openWith.Add("rtf", "wordpad.exe");

            //try
            //{
            //    openWith.Add("txt", "winword.exe");
            //}
            //catch(ArgumentException)
            //{
            //    Console.WriteLine("An element with key \"txt\" already exists.");
            //}
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(3, "Ali");
            myDictionary.Add(3, "Hasan");
            
           
            
        }
    }
}
