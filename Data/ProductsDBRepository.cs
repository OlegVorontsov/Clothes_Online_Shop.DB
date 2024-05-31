using Clothes_Online_Shop.DB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clothes_Online_Shop.DB.Data
{
    public class ProductsDBRepository : IProductsRepository
    {
        private readonly DataBaseContext dataBaseContext;

        public ProductsDBRepository(DataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }
        public void AddProduct(Product product)
        {
            dataBaseContext.Products.Add(product);
            dataBaseContext.SaveChanges();
        }
        public List<Product> GetAll()
        {
            return dataBaseContext.Products.Include(p => p.ImgList).ToList();
        }
        public Product TryGetById (Guid id)
        {
            return dataBaseContext.Products
                                  .Include(p => p.ImgList)
                                  .FirstOrDefault(product => product.Id == id);
        }
        public void Update(Product product)
        {
            var existingProduct = dataBaseContext.Products
                                                 .Include(x => x.ImgList)
                                                 .FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct == null)
            {
                return;
            }
            existingProduct.Name = product.Name;
            existingProduct.Item = product.Item;
            existingProduct.Cost = product.Cost;
            existingProduct.Size = product.Size;
            existingProduct.Color = product.Color;
            existingProduct.Care = product.Care;
            existingProduct.Fabric = product.Fabric;
            existingProduct.Brand = product.Brand;
            existingProduct.Country = product.Country;
            existingProduct.Description = product.Description;

            foreach (var img in product.ImgList)
            {
                img.ProductId = product.Id;
                dataBaseContext.ImgInfos.Add(img);
            }
            dataBaseContext.SaveChanges();
        }
        public void Delete(Guid productId)
        {
            var existingProduct = dataBaseContext.Products.FirstOrDefault(p => p.Id == productId);
            if (existingProduct == null)
            {
                return;
            }
            dataBaseContext.Products.Remove(existingProduct);
            dataBaseContext.ImgInfos.RemoveRange(dataBaseContext.ImgInfos.Where(i => i.ProductId == productId));
            dataBaseContext.FavoriteProducts.RemoveRange(dataBaseContext.FavoriteProducts.Where(p => p.Product.Id == productId));
            dataBaseContext.SaveChanges();
        }
        public List<Guid> CheckProductInItems(Guid productId)
        {
            var items = dataBaseContext.CartItems
                                       .Include(x => x.Order)
                                       .Where(i => i.Product.Id == productId).ToList();
            if (items == null)
            {
                return null;
            }
            List<Guid> listOfOrderId = new List<Guid>();
            foreach (var item in items)
            {
                if (item.Order == null)
                {
                    dataBaseContext.CartItems.Remove(item);
                    dataBaseContext.SaveChanges();
                    break;
                }
                listOfOrderId.Add(item.Order.Id);
            }
            return listOfOrderId;
        }
    }
}
