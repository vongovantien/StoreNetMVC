using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Repository
{
    public interface IProductRepository
    {
        public Task<int> AddNewProduct(ProductModel model);
        public Task<List<ProductModel>> GetAllProducts();
        public Task<ProductModel> GetProductById(int? id);
    }
}
