using System;
using System.Collections.Generic;

namespace Clothes_Online_Shop.DB.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Item { get; set; }
        public decimal Cost { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }
        public string Care { get; set; }
        public string Fabric { get; set; }
        public string Brand { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public ICollection<ImgInfo> ImgList { get; set; }
        public bool Like { get; set; }
        public List<CartItem> CartItems { get; set; }
        public Product()
        {
            CartItems = new List<CartItem>();
            ImgList = new List<ImgInfo>();
        }
    }
}
