using Clothes_Online_Shop.DB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clothes_Online_Shop.DB.Data
{
    //хранилище корзин
    public class CartsDBRepository : ICartsRepository
    {
        private readonly DataBaseContext dataBaseContext;

        public CartsDBRepository(DataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }

        public Cart TryGetByUserId(string userId)
        {
            var cart = dataBaseContext.Carts.Include(x => x.Items)
                                        .ThenInclude(x => x.Product)
                                        .ThenInclude(x => x.ImgList)
                                        .FirstOrDefault(x => x.UserId == userId);
            return cart;
        }

        public void Add(Product product, string userId)
        {
            var existingCart = TryGetByUserId(userId);
            if (existingCart == null)
            {
                var newCart = new Cart
                {
                    UserId = userId
                };
                newCart.Items = new List<CartItem>
                {
                    new CartItem
                    {
                        Amount = 1,
                        Product = product,
                        Cart = newCart
                    }
                };
                dataBaseContext.Carts.Add(newCart);
            }
            else
            {
                var existingCartItem = existingCart.Items.FirstOrDefault(x => x.Product.Id == product.Id);
                if (existingCartItem != null)
                {
                    existingCartItem.Amount += 1;
                }
                else
                {
                    existingCart.Items.Add(new CartItem
                    {
                        Amount = 1,
                        Product = product,
                        Cart = existingCart
                    });
                }
            }
            dataBaseContext.SaveChanges();
        }
        //уменьшение кол-ва позиции в корзине
        public void DecreaseAmount(Guid productId, string userId)
        {
            var existingCart = TryGetByUserId(userId);
            var existingCartItem = existingCart?.Items?.FirstOrDefault(x => x.Product.Id == productId);
            if (existingCartItem == null)
            {
                return;
            }
            existingCartItem.Amount -= 1;
            if (existingCartItem.Amount==0)
            {
                existingCart.Items.Remove(existingCartItem);
            }
            dataBaseContext.SaveChanges();
        }
        //удаление позиции из корзине
        public void DeleteItem(Guid productId, string userId)
        {
            var existingCart = TryGetByUserId(userId);
            var existingCartItem = existingCart?.Items?.FirstOrDefault(x => x.Product.Id == productId);
            if (existingCartItem == null)
            {
                return;
            }
            existingCart.Items.Remove(existingCartItem);
            dataBaseContext.SaveChanges();
        }
        //очистка корзины
        public void Clear(string userId)
        {
            var existingCart = TryGetByUserId(userId);
            dataBaseContext.Carts.Remove(existingCart);
            dataBaseContext.SaveChanges();
        }
    }
}
