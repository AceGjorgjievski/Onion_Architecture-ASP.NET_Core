using System;
using System.Collections.Generic;
using Domain;
using Repository;
using Services.Interface;

namespace Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;
        
        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return this._productRepository.GetAll();
        }

        public Product GetById(Guid id)
        {
            return this._productRepository.GetById(id);
        }
    }
}