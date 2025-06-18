import java.util.*;

// Product Class
class Product {
    String name;
    String category;
    double price;

    public Product(String name, String category, double price) {
        this.name  = name.toLowerCase();
        this.category = category.toLowerCase();
        this.price = price;
    }

    public void display() {
        System.out.println("Product Name: " + name + ", Category: " + category + ", Price: " + price);
    }
}

public class exercise3 {
    // List to store all Products
    static List<Product> products = new ArrayList<>();

    public static void addSampleProducts() {
        products.add(new Product("P1", "C1", 79999));
        products.add(new Product("P2", "C1", 59999));
        products.add(new Product("P3", "C2", 4999));
        products.add(new Product("P4", "C2", 2999));
        products.add(new Product("P5", "C3", 39999));
    }

    // Search Product by Name (Linear Search)
    public static void searchByName(String name) {
        System.out.println("Search Products by Product Name: " + name);
        boolean foundProd = false;

        for (Product product : products) {
            if (product.name.contains(name.toLowerCase())) {
                product.display();
                foundProd = true;
            }
        }

        if (!foundProd) {
            System.out.println("Product not found");
        }
    }

    // Search by Category
    public static void searchByCategory(String category) {
        System.out.println("Search Products for Category: " + category);
        boolean foundCat = false;
        
        for (Product product : products) {
            if (product.category.contains(category.toLowerCase())) {
                product.display();
                foundCat = true;
            }
        }

        if (!foundCat) {
            System.out.println("Product not found");
        }
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        addSampleProducts();

        System.out.println("E-Commerce Product Search");
        System.out.println("1. Search by Product Name");
        System.out.println("2. Search by Category");
        System.out.print("Enter your choice: ");
        int choice = scanner.nextInt();
        scanner.nextLine();

        switch (choice) {
            case 1:
                System.out.print("Enter Product Name (P1 to P5): ");
                String name = scanner.nextLine();
                searchByName(name);
                break;
            case 2:
            System.out.print("Enter Category (C1 to C3): ");
                String category = scanner.nextLine();
                searchByCategory(category);
                break;
            default:
                System.out.println("Invalid choice!");
        }

        scanner.close();
    }
}