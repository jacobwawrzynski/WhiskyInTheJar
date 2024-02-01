using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ProductsTransaction : IProductsTransaction
    {
        private readonly IProductService _productService;
        private readonly INutritionFactsService _factService;

        public ProductsTransaction(IProductService productService,
            INutritionFactsService nutritionFactsService)
        {
            _productService = productService;
            _factService = nutritionFactsService;
        }



        // TODO
        
        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void RollBack()
        {
            throw new NotImplementedException();
        }
    }
}
