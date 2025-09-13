namespace SimpleApp.Models;

public class Product
{
    public string Name { get; set; } = string.Empty;
    public decimal? Price { get; set; }
}

public class ProductDataSource : IDataSource
{
    public IEnumerable<Product> Products =>
    [
        new() { Name = "Kayak", Price = 275M },
        new() { Name = "Lifejacket", Price = 48.95M }
    ];
}