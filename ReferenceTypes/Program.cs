using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, float, enum, boolean birer value types tır. değer tipler sadece stackte oluşur
            int sayi1 = 10; //sayı1 in değeri 10 dur.
            int sayi2 = 20; //sayı2 nin değeri 20 dir.
            
            sayi1 = sayi2; //sayı1 in değeri sayı2 nin değerine yani 20 ye eşittir.

            sayi2 = 100; //

            Console.WriteLine("Sayi1 : "+sayi1);

            //array, class, interface, vb. reference type dır.
            int[] sayilar1 = new int[] {1,2,3};
            int[] sayilar2 = new int[] {10, 20, 30};

            sayilar1 = sayilar2;//sayılar1 in adresi artık sayılar2 nin adresidir.
            sayilar2[0] = 1000;

            Console.WriteLine("Sayilar1[0] = "+sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            
            person1.FirstName = "Engin";
            person2 = person1;
            Console.WriteLine(person2.FirstName);
            
            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            Person person3 = customer;  // bir person ı bir customer a atayabiliriz. Çünkü customer bir person dır. person3, customer ın adresini tutuyor.
            //person3.CreditCardNumber gelmez. Ama ulaşılmak istenirse ((Customer)person3).Credit.. yapılarsa gelir buna boxing denir

            person3.FirstName = "Salih"; 
            Console.WriteLine(customer.FirstName); 
            

            Employee employee = new Employee();
            //Employee employee1=customer ; diyemem. inheritance kavramı burada önemli

            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
            

        }
    }
    class Person // base class, ebeveyn
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Customer : Person //inheritance 
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person //
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager  
    {
        public void Add(Person person) // aynı kodu bu sayede person, customer, employee için çalıştırabiliriz.
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
