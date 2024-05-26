using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.BLL.Repositories.Abstracts.Base;
using ECommerce.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Repositories.Concretes
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repositoryProduct;

        public ProductService(IRepository<Product> repositoryProduct)
        {
            _repositoryProduct = repositoryProduct;
        }

        public async Task<string> CreateProduct(Product product)
        {
            return await _repositoryProduct.Create(product);
        }

        public async Task<string> DeleteProduct(Product product)
        {
            return await _repositoryProduct.Delete(product);
        }

        public async Task<string> DestroyProduct(Product product)
        {
            return await _repositoryProduct.DestroyData(product);
        }

        public IEnumerable<Product> GetActiveProducts()
        {
            return _repositoryProduct.GetActives();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _repositoryProduct.GetAll();
        }

        public IEnumerable<Product> GetPassiveProducts()
        {
            return _repositoryProduct.GetPassives();
        }

        public Product GetProductById(int id)
        {
            return _repositoryProduct.GetById(id);
        }

        public async  Task<string> UpdateProduct(Product Product)
        {
            return await _repositoryProduct.Update(Product);
        }
    }
}
