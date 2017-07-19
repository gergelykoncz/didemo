using System.Collections.Generic;

namespace WpfDemoApp.DataAccess
{
    public class InMemoryProductRepository : IProductRepository
    {
        private List<Product> _inner = new List<Product>()
        {
            new Product(){Id=1, Name="Bobsleigh", Description="Sliding on snow in company", Price=99.99M},
            new Product(){Id=2, Name="Ice skates", Description="Sliding on ice", Price=149.99M},
            new Product(){Id=3, Name="Thermal gloves", Description="For snowball fights", Price=29.99M},
            new Product(){Id=4, Name="Skis", Description="Sliding on snow alone", Price=299.99M},
            new Product(){Id=5, Name="Helmet", Description="For head protection", Price=99.99M},
        };

        public IEnumerable<Product> GetAll()
        {
            return _inner.AsReadOnly();
        }
    }
}
