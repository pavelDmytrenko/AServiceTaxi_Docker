using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AServiceTaxi.DL
{
    public interface ICarRepository
    {
        IQueryable<Car> Cars { get; }
        IQueryable<Order> Orders { get; }
        List<Car> GetAllCars();
        Car GetCarById(int? id);
        void AddCar(Car car);
        void DeleteCar(Car car);
        void SaveChanges();
    }
}
