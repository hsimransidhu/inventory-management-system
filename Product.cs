public class Product
{
    private string name;
    private double price;
    private int quantity;

    public string Name { get => name; set => name = value; }
    public double Price { get => price; set => price = value; }
    public int Quantity { get => quantity; set => quantity = value; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Product"/> class with specified details.
    /// </summary>
    /// <param name="name">The name of the product.</param>
    /// <param name="price">The price of the product.</param>
    /// <param name="quantity">The initial quantity of the product.</param>
    public Product(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public void UpdateQuantity(int amount)
    {
        Quantity += amount;
    }
}
