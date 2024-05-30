using System;

namespace Clothes_Online_Shop.DB.Models
{
    public class UserDeliveryInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
