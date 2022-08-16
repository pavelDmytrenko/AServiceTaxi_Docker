using AServiceTaxi.DL;

namespace AServiceTaxi.BL
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository dbContext)
        {
            _carRepository = dbContext;
        }
        public Car GetCarByID(int? id)
        {
            return _carRepository.GetCarById(id);
        }
        public List<Car> GetAllCars()
        {
            return _carRepository.GetAllCars();
        }

        public void AddCar(Car car)
        {
            var carEntity = _carRepository.GetCarById(car.CarID);
            if (carEntity == null)
            { 
                _carRepository.AddCar(car);
            }
            else
            {
                carEntity.CarNumber = car.CarNumber;
                carEntity.CarModel = car.CarModel;
                carEntity.CarDriverFIO = car.CarDriverFIO;
                carEntity.CarReady = car.CarReady;
                _carRepository.SaveChanges();
            }
        }

        public Car DeleteCar(int id)
        {
            var carEntity = _carRepository.GetCarById(id);
            if (carEntity != null)
            {
                _carRepository.DeleteCar(carEntity);
                return carEntity;
            }

            return null;
        }
    }
}
