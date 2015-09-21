using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarManager.Business;

namespace CarManager.Service
{
    public interface ICarService
    {
        List<Car> GetCars();
        Car Get(int carId);
        Car Add(Car car);
        Car Update(Car car);
        void Delete(int carId);
    }
}
