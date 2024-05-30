using Clothes_Online_Shop.DB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clothes_Online_Shop.DB.Data
{
    public class FavoriteProductDBRepository: IFavoriteProductRepository
    {
        private readonly DataBaseContext dataBaseContext;
        public FavoriteProductDBRepository(DataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }
        public void Add (string userId, Product product)
        {
            var existingProduct = dataBaseContext.FavoriteProducts
                                                 .FirstOrDefault(x => x.UserId == userId && x.Product.Id == product.Id && x.Product.Like == false);
            if (existingProduct == null)
            {
                product.Like = true;
                dataBaseContext.FavoriteProducts.Add(new FavoriteProduct { Product = product, UserId = userId });
                dataBaseContext.SaveChanges();
            }
        }
        public void Clear(string userId)
        {
            var userFavoriteProducts = dataBaseContext.FavoriteProducts.Where(u => u.UserId == userId).ToList();
            dataBaseContext.FavoriteProducts.RemoveRange(userFavoriteProducts);
            dataBaseContext.SaveChanges();
        }
        public List<Product> GetAll(string userId)
        {
            return dataBaseContext.FavoriteProducts.Where(x => x.UserId == userId)
                                                   .Include(x => x.Product)
                                                   .ThenInclude (x => x.ImgList)
                                                   .Select(x => x.Product)
                                                   .ToList();
        }
        public void Remove(string userId, Product product)
        {
            var removingProduct = dataBaseContext.FavoriteProducts
                                                 .FirstOrDefault(x => x.UserId == userId && x.Product.Id == product.Id && x.Product.Like == true);
            if (removingProduct != null)
            {
                product.Like = false;
                dataBaseContext.FavoriteProducts.Remove(removingProduct);
                dataBaseContext.SaveChanges();
            }
        }
    }
}
