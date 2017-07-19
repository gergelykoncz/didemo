using System;
namespace WpfDemoApp.DataAccess
{
    interface IProductRepository
    {
        System.Collections.Generic.IEnumerable<Product> GetAll();
    }
}
