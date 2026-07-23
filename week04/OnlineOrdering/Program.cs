using System;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address("123 Main Street", "Los Angeles", "CA 90028", "USA");
        Address kenyaAddress = new Address("100 Lucky Summer", "Nairobi", "Nrb", "Kenya");

        Customer alex = new Customer("Alex Charles", usaAddress);
        Customer mike = new Customer("Mike Jack", kenyaAddress);

        Product phone = new Product("Phone", "001", 200, 1);
        Product calculator = new Product("Calculator", "002", 50, 1);
        Product backpack = new Product("Backpack", "003", 78, 1);

        Product pen = new Product("Pen", "004", 35, 5);
        Product pencil = new Product("Pencil", "005", 20, 6);
        Product book = new Product("Book", "006", 40, 10);

        Order order1 = new Order(alex);

        order1.AddProduct(phone);
        order1.AddProduct(calculator);
        order1.AddProduct(backpack);

        Order order2 = new Order(mike);

        order2.AddProduct(pen);
        order2.AddProduct(pencil);
        order2.AddProduct(book);

        Console.WriteLine("ORDER 1");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}");

        Console.WriteLine();

        Console.WriteLine("ORDER 2");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
}