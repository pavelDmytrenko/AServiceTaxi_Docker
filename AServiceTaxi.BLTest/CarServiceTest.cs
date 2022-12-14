using AServiceTaxi.BL;
using AServiceTaxi.DL;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace AServiceTaxi.BLTest
{
    public class CarServiceTest
    {
        private List<Car> GetList()
        {
            return  new List<Car>
            {
                new Car
                                   {
                                       CarNumber = "Car1",
                                       CarModel = "Tesla",
                                       CarDriverFIO = "John Do"
                                   },
                new Car
                               {
                                   CarNumber = "Car2",
                                   CarModel = "Renault",
                                   CarDriverFIO = "Carl Jo"
                               },
                new Car
                    {
                        CarNumber = "Car3",
                        CarModel = "Maclaren",
                        CarDriverFIO = "Lewis Ham"
                    },
                new Car
                    {
                        CarNumber = "Car4",
                        CarModel = "Ferrary",
                        CarDriverFIO = "Fernando Alonso"
                    },
            new Car
                {
                    CarNumber = "Car5",
                    CarModel = "Volvo",
                    CarDriverFIO = "Seb Vettel"
                },
            new Car
                {
                    CarNumber = "Car1",
                    CarModel = "Tesla",
                    CarDriverFIO = "John Do"
                }
            };
        }
        public List<Car> GetTestCars()
        {
            List<Car> cars = GetList();
            return cars;
        }
        [Fact]
        public void BusinessLogicTestCountCars()
        {
            var mock = new Mock<ICarRepository>();
            mock.Setup(p => p.GetAllCars()).Returns(GetTestCars());
            List<Car> car = new CarService(mock.Object).GetAllCars();
            Assert.Equal(6, car.Count);
        }
    }
}
