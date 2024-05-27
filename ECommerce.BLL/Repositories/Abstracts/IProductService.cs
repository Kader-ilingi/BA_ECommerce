using ECommerce.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Repositories.Abstracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        Task<string> CreateProductAsync(Product product);
        Task<string> DeleteProductAsync(Product product);
        Task<string> UpdateProductAsync(Product product);

        IEnumerable<Product> GetActiveProducts();
        IEnumerable<Product> GetPassiveProducts();
        Task<string> DestroyProductAsync(Product product);
    }
}
