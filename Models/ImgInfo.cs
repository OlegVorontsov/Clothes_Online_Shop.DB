using System;

namespace Clothes_Online_Shop.DB.Models
{
    public class ImgInfo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
