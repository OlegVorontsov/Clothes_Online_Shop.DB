using Clothes_Online_Shop.DB.Models;
using System;
using System.Collections.Generic;

namespace Clothes_Online_Shop.DB.Data
{
    public interface IOrdersRepository
    {
        public void Add(Order order);
        List<Order> GetAll();
        Order TryGetById(Guid orderId);
        void DeleteOrder(Guid orderId);
        void UpdateStatus(Guid orderId, OrderStatus newStatus);
    }
}