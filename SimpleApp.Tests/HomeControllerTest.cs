using SimpleApp.Controllers;
using SimpleApp.Models;

namespace SimpleApp.Tests;

public class HomeControllerTest
{
    [Fact]
    public void IndexActionModelIsComplete()
    {
        // Arrange
        var testData = new[]
        {
            new Product { Name = "Kayak", Price = 275M },
            new Product { Name = "Lifejacket", Price = 48.95M }
        };

        var data = new FakeDataSource(testData);
        var controller = new HomeController();
        controller.dataSource = data;

        //Act
        var model = controller.Index().ViewData
            .Model as IEnumerable<Product>;

        // Assert
        Assert.NotNull(model);
        Assert.Equal(data.Products, model,
            Comparer.Get<Product>((p1, p2) => p1?.Name == p2?.Name
                                              && p1?.Price == p2?.Price));
    }

    private class FakeDataSource(Product[] data) : IDataSource
    {
        public IEnumerable<Product> Products { get; } = data;
    }
}