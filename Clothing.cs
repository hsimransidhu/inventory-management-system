
/// <summary>
/// Represents a clothing product.
/// </summary>
public class Clothing : Product
{
    public string Size { get; set; }


    /// <summary>
    /// Initializes a new instance of the <see cref="Clothing"/> class with specified details.
    /// </summary>
    /// <param name="name">The name of the clothing product.</param>
    /// <param name="price">The price of the clothing product.</param>
    /// <param name="quantity">The initial quantity of the clothing product.</param>
    /// <param name="size">The size of the clothing product.</param>

    public Clothing(string name, double price, int quantity, string size)
        : base(name, price, quantity)
    {
        Size = size;
    }
     
}
