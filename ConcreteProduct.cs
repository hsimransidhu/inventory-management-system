using System;

//Represents a concrete class for products
public class ConcreteProduct : AbstractProduct
{
    public override string Name { get; set; }
    public override double Price { get; set; }
    public override int Quantity { get; set; }

}
