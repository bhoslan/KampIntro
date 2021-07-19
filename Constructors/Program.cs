using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() {Id=1, Name="Engin", LastName="Demirog", City="Ankara" }; // Id Name PascalCase kullan
            Customer customer2 = new Customer(2, "A", "B", "C");
            Console.WriteLine(customer2.Name);
        }
    }

    class Customer
    {
        public Customer() // parametresi olmayan constructor default constructor dır.
        {

        }
        public Customer(int id, string name, string lastName, string city ) //class ın ismiyle aynı ve geri dönüş tipi yok. new lendiğinde bu blok çalışır. 
        {                                                                   //metot parametreleri camelCase yazılır
            Id = id;
            Name = name;
            LastName = lastName;
            City = city;

        }
        public int Id { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }
        public String City { get; set; }
    }
}
