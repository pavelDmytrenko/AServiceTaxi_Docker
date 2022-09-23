using AServiceTaxi.DL;

namespace AServiceTaxi.BL
{
    public interface ICarService
    {
        Car GetCarByID(int id);
        List<Car> GetAllCars();
        Car AddCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(int id);
    }
}
