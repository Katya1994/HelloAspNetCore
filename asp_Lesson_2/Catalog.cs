namespace asp_Lesson_2;

public class Catalog
{
    private static IList<Product> Products { get; } = new List<Product>()
    {
        new Product(100, "Хлеб"),
        new Product(49, "Картошка"),
        new Product(120, "Молоко"),
        new Product(50, "Колбаса")
    };

    public string[] ProductNames { get; }

    private readonly IMyDayOfWeek myDate;

    public Catalog(IMyDayOfWeek myDate)
    {
        this.myDate = myDate;
    }

    public string ShowProducts()
    {
        int i = 0;
        foreach (var product in Products)
        {
            if ((myDate.Date.DayOfWeek == DayOfWeek.Saturday) && (myDate.Date.DayOfWeek == DayOfWeek.Sunday))
            {
                product.Price += product.Price * 0.5m;
                ProductNames[i] = $"{product.Name} = {product.Price}";
                ++i;
            }
        }

        return ProductNames[1];
    }
}