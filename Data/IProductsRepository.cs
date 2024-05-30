using Clothes_Online_Shop.DB.Models;
using System;
using System.Collections.Generic;

namespace Clothes_Online_Shop.DB.Data
{
    public interface IProductsRepository
    {
        Product TryGetById(Guid id);
        List<Product> GetAll();
        void AddProduct(Product product);
        void Update(Product product);
        public void Delete(Guid productId);
        List<Guid> CheckProductInItems(Guid productId);
    }
}
