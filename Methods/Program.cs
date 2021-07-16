using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            int result=Add2(12, 23);
            Console.WriteLine(result);
            Add();
            Console.WriteLine(Multiply(2,3));
            Console.ReadKey();
        }
        
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        
        static int Add2(int number1, int number2) //int number2=10 denirse default olarak 2.sayı 10olur. Default sonda olmalı 
        {
            int result;
            result = number1 + number2;
            return result;
        }

        static int Multiply (int number1, int number2)
        {
            return number1 * number2;
        }

        static int Add3 (params int[] numbers)
        {
            int sum = numbers.Sum();
            return sum;
        }











    }
}
