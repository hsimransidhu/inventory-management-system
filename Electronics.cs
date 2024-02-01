using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents an electronics product.
/// </summary>
public class Electronics : Product
{
    public string Manufacturer { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Electronics"/> class with specified details.
    /// </summary>
    /// <param name="name">The name of the electronics product.</param>
    /// <param name="price">The price of the electronics product.</param>
    /// <param name="quantity">The initial quantity of the electronics product.</param>
    /// <param name="manufacturer">The manufacturer of the electronics product.</param>
    public Electronics(string name, double price, int quantity, string manufacturer)
        : base(name, price, quantity)
    {
        Manufacturer = manufacturer;
    }

}

