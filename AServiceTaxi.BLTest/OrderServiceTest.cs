using AServiceTaxi.BL;
using AServiceTaxi.DL;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace AServiceTaxi.BLTest
{ 
    public class OrderServiceTest
    {
        private List<Order> GetListOrder()
        {
            return new List<Order>
            {
                new Order
                {
                    OrderDate = Convert.ToDateTime("08/13/2021 10:00"),
                    OrderComplateDate = Convert.ToDateTime("08/13/2021 11:00"),
                    OrderAddressSource = "Simi Prakhovykh, 54",
                    OrderAddressDestination = "Kudryashova, 14-B",
                    OrderStatus = ((int) OrderStatus.Done),
                    CarID = 1
                },
                new Order
                {
                    OrderDate = Convert.ToDateTime("08/13/2021 08:00"),
                    OrderComplateDate = Convert.ToDateTime("08/13/2021 09:00"),
                    OrderAddressSource = "Simi Prakhovykh, 54",
                    OrderAddressDestination = "Kudryashova, 14-B",
                    OrderStatus = ((int) OrderStatus.Done),
                    CarID = 3
                },
                new Order
                {
                    OrderDate = Convert.ToDateTime("08/13/2021 9:00"),
                    OrderComplateDate = Convert.ToDateTime("08/13/2021 9:30"),
                    OrderAddressSource = "Simi Prakhovykh, 54",
                    OrderAddressDestination = "Kudryashova, 14-B",
                    OrderStatus = ((int) OrderStatus.Done),
                    CarID = 5
                },
                new Order
                {
                    OrderDate = Convert.ToDateTime("08/13/2021 11:00"),
                    OrderAddressSource = "Simi Prakhovykh, 54",
                    OrderAddressDestination = "Kudryashova, 14-B",
                    OrderStatus = ((int) OrderStatus.Waiting)
                },
                new Order
                {
                    OrderDate = Convert.ToDateTime("08/13/2021 11:00"),
                    OrderAddressSource = "Simi Prakhovykh, 54",
                    OrderAddressDestination = "Kudryashova, 14-B",
                    OrderStatus = ((int) OrderStatus.InProgress),
                    CarID = 6
                },
                new Order
                {
                    OrderDate = Convert.ToDateTime("08/13/2021 12:00"),
                    OrderAddressSource = "Simi Prakhovykh, 54",
                    OrderAddressDestination = "Kudryashova, 14-B",
                    OrderStatus = ((int) OrderStatus.InProgress),
                    CarID = 3
                },
                new Order
                {
                    OrderDate = Convert.ToDateTime("08/13/2021 10:00"),
                    OrderComplateDate = Convert.ToDateTime("08/13/2021 11:00"),
                    OrderAddressSource = "Simi Prakhovykh, 54",
                    OrderAddressDestination = "Kudryashova, 14-B",
                    OrderStatus = ((int) OrderStatus.Done),
                    CarID = 5
                }
            };
        }

        private List<Car> GetListCar()
    {
        return  new List<Car>
            {
                new Car
                                   {
                                       CarNumber = "Car1",
                                       CarModel = "Tesla",
                                       CarDriverFIO = "John Do",
                                       CarReady = true
                                   },
                new Car
                               {
                                   CarNumber = "Car2",
                                   CarModel = "Renault",
                                   CarDriverFIO = "Carl Jo",
                                   CarReady = true
                               },
                new Car
                    {
                        CarNumber = "Car3",
                        CarModel = "Maclaren",
                        CarDriverFIO = "Lewis Ham",
                        CarReady = false
                    },
                new Car
                    {
                        CarNumber = "Car4",
                        CarModel = "Ferrary",
                        CarDriverFIO = "Fernando Alonso",
                        CarReady = true
                    },
            new Car
                {
                    CarNumber = "Car5",
                    CarModel = "Volvo",
                    CarDriverFIO = "Seb Vettel",
                    CarReady = true
                },
            new Car
                {
                    CarNumber = "Car1",
                    CarModel = "Tesla",
                    CarDriverFIO = "John Do",
                    CarReady = false
                }
            };
    }
    public List<Order> GetTestOrders()
    {
        List<Order> orders = GetListOrder();
        return orders;
    }

    private List<Order> GetTestWaitngOrders()
    {
        var orders = new List<Order>
            {
            new Order
            {
                OrderDate = Convert.ToDateTime("08/13/2021 11:00"),
                OrderAddressSource = "Simi Prakhovykh, 54",
                OrderAddressDestination = "Kudryashova, 14-B",
                OrderStatus = ((int)OrderStatus.Waiting)
            }};
        return orders;
    }
    private List<Car> GetTestCars()
    {
        List<Car> cars = GetListCar();
        return cars;
    }
    [Fact]
    public async void OrderServiceTestCountOrders()
    {
        var mockOrder = new Mock<IOrderRepository>();
        var mockCar = new Mock<ICarRepository>();
        mockOrder.Setup(p => p.GetOrder()).Returns(GetTestOrders());
        mockCar.Setup(p => p.GetAllCars()).Returns(GetTestCars());
        var order = new OrderService(mockOrder.Object, mockCar.Object).GetOrders();
        Assert.Equal(7, order.Count);
    }
}
}
