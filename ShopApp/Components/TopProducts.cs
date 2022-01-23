using Microsoft.AspNetCore.Mvc;
using ShopApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Components
{
    public class TopProducts: ViewComponent
    {
        private readonly ProductRepository _productRepository;

        public TopProducts(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = await _productRepository.GetTopProducts();
            return View(products);
        }
    }
}
