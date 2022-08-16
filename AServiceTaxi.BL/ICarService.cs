using AServiceTaxi.DL;

namespace AServiceTaxi.BL
{
    public interface ICarService
    {
        Car GetCarByID(int? id);
        List<Car> GetAllCars();
        void AddCar(Car car);
        Car DeleteCar(int id);
    }
}
