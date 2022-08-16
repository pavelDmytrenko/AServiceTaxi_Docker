using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AServiceTaxi.DL
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get ; }
        IQueryable<Car> Cars { get; }
        List<Order> GetOrder();
        Order GetOrderById(int? id);
        void AddOrder(Order order);
        void DelOrder(Order order);
        void SaveChanges();

    }
}
