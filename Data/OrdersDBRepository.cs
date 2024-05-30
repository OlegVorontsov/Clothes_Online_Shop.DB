using Clothes_Online_Shop.DB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clothes_Online_Shop.DB.Data
{
    //хранилище заказов
    public class OrdersDBRepository : IOrdersRepository
    {
        private readonly DataBaseContext dataBaseContext;
        public OrdersDBRepository(DataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }

        public void Add(Order order)
        {
            dataBaseContext.Orders.Add(order);
            dataBaseContext.SaveChanges();
        }

        public void DeleteOrder(Guid orderId)
        {
            var order = TryGetById(orderId);
            if (order!=null)
            {
                dataBaseContext.CartItems.RemoveRange(dataBaseContext.CartItems.Where(i => i.Order.Id == orderId));
                dataBaseContext.Remove(order);
                dataBaseContext.SaveChanges();
            }
        }

        public List<Order> GetAll()
        {
            var orders = dataBaseContext.Orders.Include(x => x.UserInfo)
                                         .Include(x => x.Items)
                                         .ThenInclude(x => x.Product)
                                         .ToList();
            return orders;
        }

        public Order TryGetById(Guid orderId)
        {
            var order = dataBaseContext.Orders.Include(x => x.UserInfo)
                                         .Include(x => x.Items)
                                         .ThenInclude(x => x.Product)
                                         .FirstOrDefault(o => o.Id == orderId);
            return order;
        }

        public void UpdateStatus(Guid orderId, OrderStatus newStatus)
        {
            var order = TryGetById(orderId);
            if (order != null)
            {
                order.Status = newStatus;
                dataBaseContext.SaveChanges();
            }
        }
    }
}
