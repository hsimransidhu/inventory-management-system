using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_OOPS
{
   
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of products
            Electronics laptop = new Electronics("Laptop", 999.99, 10, "Asus");
            Clothing dress = new Clothing("Ethnic Dress", 19.99, 50, "M");
            Groceries pears = new Groceries("Pears", 1.49, 100, "2024-02-15");

            // Create inventory and add products
            Inventory inventory = new Inventory();
            inventory.AddProduct(laptop);
            inventory.AddProduct(dress);
            inventory.AddProduct(pears);

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("          Welcome to Our Retail Store        ");
            Console.WriteLine("---------------------------------------------\n");

            // Display Electronics details
            Console.WriteLine("---------------- Electronics ----------------");
            Console.WriteLine($"Product Name: {laptop.Name}");
            Console.WriteLine($"Price: ${laptop.Price}");
            Console.WriteLine($"Manufacturer: {laptop.Manufacturer}");
            Console.WriteLine($"Quantity: {laptop.Quantity}");
            Console.WriteLine("---------------------------------------------");

            // Display Clothing details
            Console.WriteLine("\n---------------- Clothing -------------------");
            Console.WriteLine($"Product Name: {dress.Name}");
            Console.WriteLine($"Price: ${dress.Price}");
            Console.WriteLine($"Size: {dress.Size}");
            Console.WriteLine($"Quantity: {dress.Quantity}");
            Console.WriteLine("---------------------------------------------");

            // Display Groceries details
            Console.WriteLine("\n---------------- Groceries ------------------");
            Console.WriteLine($"Product Name: {pears.Name}");
            Console.WriteLine($"Price: ${pears.Price}");
            Console.WriteLine($"Expiration Date: {pears.ExpirationDate}");
            Console.WriteLine($"Quantity: {pears.Quantity}");
            Console.WriteLine("---------------------------------------------\n");

            // Perform transactions
            Console.WriteLine("Performing Transactions...\n");
            Transaction laptopTransaction = new Transaction(laptop, 2);
            laptopTransaction.ProcessTransaction();

            Transaction shirtTransaction = new Transaction(dress, 5);
            shirtTransaction.ProcessTransaction();

            Transaction appleTransaction = new Transaction(pears, 20);
            appleTransaction.ProcessTransaction();

            Console.WriteLine("---------------------------------------------\n");

           

            // Display updated inventory
            Console.WriteLine("Updated Inventory:\n");
            foreach (Product product in inventory.Products)
            {
                Console.WriteLine($"Product Name: {product.Name}");
                Console.WriteLine($"Price: ${product.Price}");
                Console.WriteLine($"Quantity: {product.Quantity}\n");
            }
        }
    }


}

