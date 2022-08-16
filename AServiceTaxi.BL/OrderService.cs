using AServiceTaxi.DL;
using System.Collections.Generic;

namespace AServiceTaxi.BL
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ICarRepository _carRepository;

        public OrderService(IOrderRepository orderRepository,ICarRepository carRepository)
        {
            _orderRepository = orderRepository;
            _carRepository = carRepository;
        }

        public Order GetOrder(int? id)
        {
            return _orderRepository.GetOrderById(id);
        }

        public List<Order> GetOrders()
        {
            return _orderRepository.GetOrder();
        }

        public void AddOrder(Order order)
        {
            if (order.OrderId == 0)
            {
                order.OrderStatus = ((int)OrderStatus.Waiting);
                _orderRepository.AddOrder(order);
            }
            else if (order.OrderId > 0)
            {
                var carEntity = _carRepository.GetCarById(order.CarID);
                var orderEntity = _orderRepository.GetOrderById(order.OrderId);
                if (order.OrderStatus == (int)OrderStatus.InProgress)
                {
                    carEntity.CarReady = true;
                    _carRepository.SaveChanges();
                    orderEntity.OrderComplateDate = order.OrderComplateDate;
                    orderEntity.OrderStatus = ((int) OrderStatus.Done);
                    _orderRepository.SaveChanges();
                }
                else if (order.OrderStatus == (int)OrderStatus.Waiting)
                {
                    carEntity.CarReady = false;
                    _carRepository.SaveChanges();
                    orderEntity.OrderStatus = ((int)OrderStatus.InProgress);
                    orderEntity.CarID = order.CarID;
                    _orderRepository.SaveChanges();
                }
            }
        }

            public Order DelOrder(int id)
            {
            var orderEntityDel = _orderRepository.GetOrderById(id);
            if (orderEntityDel != null)
            {
                if (orderEntityDel.CarID != null)
                {
                    var carEntityFree = _carRepository.GetCarById(orderEntityDel.CarID);
                    carEntityFree.CarReady = true;
                    _carRepository.SaveChanges();

                }
                _orderRepository.DelOrder(orderEntityDel);
                return orderEntityDel;
            }

            return null;
            }
    }
}
