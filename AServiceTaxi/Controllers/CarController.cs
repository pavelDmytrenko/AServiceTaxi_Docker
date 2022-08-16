using AServiceTaxi.BL;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AServiceTaxi
{
    [ApiController]
    [Route("api/cars")]
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet]
        public IEnumerable<DL.Car> Get()
        {
            return _carService.GetAllCars();
        }

        [HttpGet("{id}")]
        public DL.Car Get(int id)
        {
            return _carService.GetCarByID(id); 
        }

        [HttpPost]
        public IActionResult Post(DL.Car car)
        {
            if (ModelState.IsValid)
            {
                _carService.AddCar(car);
                return Ok(car);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_carService.DeleteCar(id));
        }
    }
}