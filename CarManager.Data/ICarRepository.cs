using CarManager.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager.Data
{
    public interface ICarRepository
    {
        List<Car> GetCars();
        Car Get(int carId);
        Car Add(Car car);
        Car Update(Car car);
        void Delete(int carId);
    }
}
