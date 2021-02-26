using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //değer tip : int, decimal, float, double, bool.
            //referans tip : array, class, interface

            // stack te sayi1, sayi2 tanımlandı.sayi1 in değeri 
            //sayi2 nin değerine eşittir. değer tipler sadece stack te gerçekleşir.

            /*
             * stack            heap
             * (101)sayilar1 ----->(101)  [10,20,30]
             * (102)sayilar2 ----->(102)  [100, 200, 300]
             * sayilar1=sayilar2 dersen sayilar1 sartık 102ye gider
             * heapteki 101 e kimse referans olmadığı için garbage collector 
             * tarafından temizlenir. 
             *  
            */
        }
    }
}
