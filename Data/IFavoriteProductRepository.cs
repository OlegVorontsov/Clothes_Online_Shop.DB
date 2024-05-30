using Clothes_Online_Shop.DB.Models;
using System;
using System.Collections.Generic;

namespace Clothes_Online_Shop.DB.Data
{
    public interface IFavoriteProductRepository
    {
        void Add(string userId, Product product);
        void Clear(string userId);
        List<Product> GetAll(string userId);
        void Remove(string userId, Product product);
    }
}