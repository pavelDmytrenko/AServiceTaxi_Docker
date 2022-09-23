using AServiceTaxi.DL;
using System.Runtime.CompilerServices;

namespace AServiceTaxi.BL
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository dbContext)
        {
            _carRepository = dbContext;
        }
        public Car GetCarByID(int id)
        {
            return _carRepository.GetCarById(id);
        }
        public List<Car> GetAllCars()
        {
            return _carRepository.GetAllCars();
        }

        public Car AddCar(Car car)
        {
            _carRepository.AddCar(car);
            return car; 
        }
        public void UpdateCar(Car car)
        {
            var carEntity = _carRepository.GetCarById(car.CarID);
            carEntity.CarNumber = car.CarNumber;
            carEntity.CarModel = car.CarModel;
            carEntity.CarDriverFIO = car.CarDriverFIO;
            carEntity.CarReady = car.CarReady;
            _carRepository.SaveChanges();
        }

        public void DeleteCar(int id)
        {
            var carEntity = _carRepository.GetCarById(id);
            if (carEntity != null)
            {
                _carRepository.DeleteCar(carEntity);
            }
        }
    }
}
