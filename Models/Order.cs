using System;
using System.Collections.Generic;

namespace Clothes_Online_Shop.DB.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public UserDeliveryInfo UserInfo { get; set; }
        public List<CartItem> Items { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public Order()
        {
            Status = OrderStatus.Created;
            CreatedDateTime = DateTime.Now;
        }
    }
}
