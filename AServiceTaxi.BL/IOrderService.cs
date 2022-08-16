using AServiceTaxi.DL;
using System.Collections.Generic;

namespace AServiceTaxi.BL
{ 
    public interface IOrderService
    {
        Order GetOrder(int? id);
        List<Order> GetOrders();
        void AddOrder(Order order);
        Order DelOrder(int id);

    }
}
