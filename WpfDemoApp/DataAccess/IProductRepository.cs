using System;
namespace WpfDemoApp.DataAccess
{
    public interface IProductRepository
    {
        System.Collections.Generic.IEnumerable<Product> GetAll();
    }
}
