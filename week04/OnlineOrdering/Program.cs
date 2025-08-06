using System;
using OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Shelbyville", "IL", "USA");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);ihatethis

        Product product1 = new Product("Laptop", "001", 999.99, 1);
        Product product2 = new Product("Smartphone", "002", 499.99, 2);
        Product product3 = new Product("Headphones", "003", 199.99, 2);
        Product product4 = new Product("Smartwatch", "004", 299.99, 1);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Order 1 Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine();

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Order 2 Total Cost: ${order2.CalculateTotalCost()}");

    }
}