using AServiceTaxi.DL;
using System.Collections.Generic;

namespace AServiceTaxi.BL
{ 
    public interface IOrderService
    {
        Order GetOrder(int id);
        List<Order> GetOrders();
        Order AddOrder(Order order);
        void UpdateOrder(Order order);
        void DelOrder(int id);

    }
}
