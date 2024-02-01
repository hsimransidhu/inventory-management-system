using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a groceries product.
/// </summary>
public class Groceries : Product
{
    public string ExpirationDate { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Groceries"/> class with specified details.
    /// </summary>
    /// <param name="name">The name of the groceries product.</param>
    /// <param name="price">The price of the groceries product.</param>
    /// <param name="quantity">The initial quantity of the groceries product.</param>
    /// <param name="expirationDate">The expiration date of the groceries product.</param>
    public Groceries(string name, double price, int quantity, string expirationDate)
        : base(name, price, quantity)
    {
        ExpirationDate = expirationDate;
    }
     
}
