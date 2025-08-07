using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Maple Street", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm Street", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Dough", address1);
        Customer customer2 = new Customer("Jane Sucre", address2);

        // Create products
        Product product1 = new Product("Witget", "W123", 3.99m, 2);
        Product product2 = new Product("NotPhone", "G456", 7.99m, 1);
        Product product3 = new Product("Notmilk", "T789", 12.99m, 3);
        Product product4 = new Product("Kazoo", "D012", 5.49m, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order details
        Console.WriteLine("Order 1:");
        
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotal():F2}\n");

        Console.WriteLine("Order 2:");
        
        Console.WriteLine(order2.GetPackingLabel());
        
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotal():F2}\n");
    }
}
