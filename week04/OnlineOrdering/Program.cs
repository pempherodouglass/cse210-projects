using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();

        Address address1 = new Address("450 Center Street", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Brian Miller", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Wireless Mouse", "P101", 25.50, 2));
        order1.AddProduct(new Product("Keyboard", "P102", 45.00, 1));
        order1.AddProduct(new Product("USB Cable", "P103", 10.00, 3));

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine();

        Address address2 = new Address("Area 49, Sector 2", "Lilongwe", "Central Region", "Malawi");
        Customer customer2 = new Customer("Pemphero Douglass", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Headphones", "P201", 80.00, 1));
        order2.AddProduct(new Product("Laptop Stand", "P202", 30.00, 2));

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
    }
}
