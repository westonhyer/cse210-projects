using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Soloman Dr.","Sunflower Valley", "Texas", "USA");
        Address address2 = new Address("456 David St.", "Cold Lake", "Alberta", "Canada");
        
        Customer customer1 = new Customer("Bob the Builder", address1);
        Customer customer2 = new Customer("James 'Logan' Howlett", address2);

        List<Product> products1 = new List<Product>()
        {
            new Product("Hammer", "4815", 78.89, 1),
            new Product("Tape Measure", "4512", 40.19, 1),
            new Product("Nail Box - 5000ct.", "4978", 74.99, 5)
        };
        List<Product> products2 = new List<Product>()
        {
            new Product("Tank Top", "1546", 12.99, 6),
            new Product("Metal Files", "4865", 34.65, 1),
            new Product("Hair Gel", "1423", 7.85, 4)
        };

        Order order1 = new Order(products1, customer1);
        Order order2 = new Order(products2, customer2);

        Console.WriteLine($"Shipping Lable:\n{order1.GetShippingLabel()}");
        Console.WriteLine();
        Console.WriteLine("Packing Lable:");
        order1.GetPackingLabel();
        order1.CalculateCost();

        Console.WriteLine();
        Console.WriteLine("--------------------------");
        Console.WriteLine();

        Console.WriteLine($"Shipping Lable:\n{order2.GetShippingLabel()}");
        Console.WriteLine();
        Console.WriteLine("Packing Lable:");
        order2.GetPackingLabel();
        order2.CalculateCost();
    }
}