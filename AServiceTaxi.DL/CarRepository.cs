using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AServiceTaxi.DL
{
    public class CarRepository : ICarRepository
    {
        private readonly IDbContext _context;
        public IQueryable<Car> Cars { get { return _context.Car; } }
        public IQueryable<Order> Orders { get { return _context.Order; } }
        public CarRepository(IDbContext dbContext)
        {
            _context = dbContext;
        }

        public List<Car> GetAllCars()
        {
            return _context.Car.ToList();
        }
        public Car GetCarById(int? id)
        {
            return _context.Car.Find(id);
        }
        public void AddCar(Car car)
        {
            car.CarReady = true;
             _context.Car.Add(car);
             _context.SaveChange();
        }

        public void DeleteCar(Car car)
        {
            _context.Car.Remove(car);
            _context.SaveChange();
        }

        public void SaveChanges()
        {
            _context.SaveChange();
        }
    }
}
