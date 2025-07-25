﻿class Product
{
    public string Name { get; }
    public string Category { get; }
    public double Price { get; }

    public Product(string name, string category, double price)
    {
        Name = name.ToLower();
        Category = category.ToLower();
        Price = price;
    }

    public void Display()
    {
        Console.WriteLine($"Product Name: {Name}, Category: {Category}, Price: {Price}");
    }
}

class exercise3
{
    static List<Product> products = new List<Product>();
    static Dictionary<string, HashSet<Product>> catMap = new Dictionary<string, HashSet<Product>>();

    static void AddSampleProducts()
    {
        AddProduct(new Product("P1", "C1", 79999));
        AddProduct(new Product("P2", "C1", 59999));
        AddProduct(new Product("P3", "C2", 4999));
        AddProduct(new Product("P4", "C2", 2999));
        AddProduct(new Product("P5", "C3", 39999));
    }

    static void AddProduct(Product p)
    {
        products.Add(p);
        if (!catMap.ContainsKey(p.Category))
            catMap[p.Category] = new HashSet<Product>();
        catMap[p.Category].Add(p);
    }

    static void SearchByName(string name)
    {
        Console.WriteLine($"Search Products by Product Name: {name}");
        bool found = false;
        foreach (var p in products)
        {
            if (p.Name.Contains(name.ToLower()))
            {
                p.Display();
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("Product not found.");
    }

    static void SearchByCategory(string category)
    {
        Console.WriteLine($"Search Products for Category: {category}");
        if (catMap.TryGetValue(category.ToLower(), out var productSet) && productSet.Count > 0)
        {
            foreach (var p in productSet)
                p.Display();
        }
        else
        {
            Console.WriteLine("No products found in this category.");
        }
    }

    static void Main()
    {
        AddSampleProducts();
        while (true)
        {
            Console.WriteLine("\nE-Commerce Product Search");
            Console.WriteLine("1. Search by Product Name");
            Console.WriteLine("2. Search by Category");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");

            string? input = Console.ReadLine();
            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Product Name (P1 to P5): ");
                    string? name = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(name))
                        SearchByName(name);
                    else
                        Console.WriteLine("Invalid product name.");
                    break;

                case 2:
                    Console.Write("Enter Category (C1 to C3): ");
                    string? category = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(category))
                        SearchByCategory(category);
                    else
                        Console.WriteLine("Invalid category.");
                    break;

                case 0:
                    Console.WriteLine("Exiting the program. Thank you!");
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
