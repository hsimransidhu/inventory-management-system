using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a transaction of a product.
/// </summary>
public class Transaction
{
    private Product product;
    private int quantity;


    /// <summary>
    /// Initializes a new instance of the <see cref="Transaction"/> class with specified product and quantity.
    /// </summary>
    /// <param name="product">The product for the transaction.</param>
    /// <param name="quantity">The quantity of the product for the transaction.</param>
    public Transaction(Product product, int quantity)
    {
        this.product = product;
        this.quantity = quantity;
    }

    // Methods for processing transactions
    public void ProcessTransaction()
    {
        
        product.UpdateQuantity(-quantity); // Reduce quantity after transaction
    }
}
