using System;
using System.Collections.Generic;
using Domain;

namespace Services.Interface
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetById(Guid id);
    }
}