using Clothes_Online_Shop.DB.Models;
using System;

namespace Clothes_Online_Shop.DB.Data
{
    public interface ICartsRepository
    {
        Cart TryGetByUserId(string userId);
        void Add(Product product, string userId);
        void DecreaseAmount(Guid productId, string userId);
        void DeleteItem(Guid productId, string userId);
        void Clear(string userId);
    }
}
