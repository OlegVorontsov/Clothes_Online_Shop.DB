using System;

namespace Clothes_Online_Shop.DB.Models
{
    //продукт в корзине
    public class CartItem
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public Cart Cart { get; set; }
        public Order Order { get; set; }
        public int Amount { get; set; }
    }
}
