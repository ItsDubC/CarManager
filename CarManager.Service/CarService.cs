using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarManager.Business;
using CarManager.Data;

namespace CarManager.Service
{
    public class CarService : ICarService
    {
        private ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public List<Car> GetCars()
        {
            return _carRepository.GetCars();
        }

        public Car Add(Car car)
        {
            return _carRepository.Add(car);
        }

        public Car Update(Car car)
        {
            return _carRepository.Update(car);
        }

        public void Delete(int carId)
        {
            _carRepository.Delete(carId);
        }

        public Car Get(int carId)
        {
            return _carRepository.Get(carId);
        }
    }
}
