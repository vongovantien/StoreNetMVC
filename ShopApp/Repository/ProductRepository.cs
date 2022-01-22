using Microsoft.EntityFrameworkCore;
using ShopApp.Data;
using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Repository
{
    public class ProductRepository: IProductRepository
    {
        private readonly MyDBContext _context;

        public ProductRepository(MyDBContext context)
        {
            _context = context;
        }

        public async Task<int> AddNewProduct(ProductModel model)
        {
            var newProduct = new Product()
            {
                ProductName = model.ProductName,
                Supplier = model.Supplier,
                UnitPrice = model.UnitPrice,
                Category = model.Category
            };

            await _context.Products.AddAsync(newProduct);
            await _context.SaveChangesAsync();

            return newProduct.ProductId;
        }

        public async Task<List<ProductModel>> GetAllProducts()
        {
            return await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                  .Select(p => new ProductModel()
                  {
                      ProductName = p.ProductName,
                      Supplier = p.Supplier,
                      UnitPrice = p.UnitPrice,
                      Category = p.Category
                  }).ToListAsync();
        }

        public async Task<ProductModel> GetProductById(int? id)
        {
            return await _context.Products.Where(x => x.ProductId == id)
                  .Include(p => p.Category)
                .Include(p => p.Supplier)
               .Select(p => new ProductModel()
               {
                   ProductId = p.ProductId,
                   ProductName = p.ProductName,

                   Quantity = p.Quantity,
                   UnitPrice = p.UnitPrice,
                   ImageUrl = p.Image,
                   Category = p.Category,
                   Supplier = p.Supplier
               }).FirstOrDefaultAsync();
        }
    }
}
