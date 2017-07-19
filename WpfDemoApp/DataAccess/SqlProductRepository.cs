using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemoApp.DataAccess
{
    public class SqlProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetAll()
        {
            // SELECT * FROM Products
        }
    }
}
