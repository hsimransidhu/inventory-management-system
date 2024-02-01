using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents the inventory of products.
/// </summary>
public class Inventory
{
     
    private List<Product> products;

    public List<Product> Products { get => products; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Inventory"/> class.
    /// </summary>
    public Inventory()
    {
        products = new List<Product>();
    }

    /// <summary>
    /// Adds a product to the inventory.
    /// </summary>
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

   
}


    

