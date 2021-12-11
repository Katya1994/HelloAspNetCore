namespace asp_Lesson_2;

public class Product
{
    
    public decimal Price { get; set; }
    public string Name { get; set; }

    public Product(decimal price, string name)
    {
        this.Price = price;
        this.Name = name;
    }
}