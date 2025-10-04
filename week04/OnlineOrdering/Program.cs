using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        // --- First Order ---
        Address address1 = new Address("123 Main Street", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product(101, "Laptop", 1200.50, 1));
        order1.AddProduct(new Product(102, "Wireless Mouse", 25.99, 2));
        order1.AddProduct(new Product(103, "USB-C Cable", 9.99, 3));

        Console.WriteLine("===== Order 1 =====");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalOrder():0.00}\n");

        // --- Second Order ---
        Address address2 = new Address("45 Avenida Central", "Lima", "Lima", "Peru");
        Customer customer2 = new Customer("Maria Gonzalez", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product(201, "Smartphone", 800.00, 1));
        order2.AddProduct(new Product(202, "Bluetooth Headphones", 59.99, 1));

        Console.WriteLine("===== Order 2 =====");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalOrder():0.00}\n");
    }
}