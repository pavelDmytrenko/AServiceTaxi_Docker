using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace AServiceTaxi.DL
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IDbContext _context;
        public IQueryable<Order> Orders { get { return _context.Order; } }
        public IQueryable<Car> Cars { get { return _context.Car; } }
        public OrderRepository(IDbContext dbContext)
        {
            _context = dbContext;
        }

        public List<Order> GetOrder()
        {
            return _context.Order.ToList();
        }

        public Order GetOrderById(int? id)
        {
            return _context.Order.Find(id);
        }
        public void AddOrder(Order order)
        {
            _context.Order.Add(order);
            _context.SaveChange();
        }
        public void DelOrder(Order order)
        {
            _context.Order.Remove(order);
            _context.SaveChange();
        }

        public void SaveChanges()
        {
            _context.SaveChange();
        }
    }
}
