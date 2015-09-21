using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarManager.Business;

namespace CarManager.Data
{
    public class DummyCarRepository : ICarRepository
    {
        private List<Car> _cars;
        private int _carIdIndex;
        public DummyCarRepository()
        {
            _cars = new List<Car> {
                new Car { CarId = 1, Make = "Volvo", Model = "740 Turbo", Year = new DateTime(1989, 1, 1), Color = "Green" },
                new Car { CarId = 2, Make = "Volvo", Model = "850", Year = new DateTime(1997, 1, 1), Color = "White" },
                new Car { CarId = 3, Make = "Audi", Model = "A4 Quattro", Year = new DateTime(2009, 1, 1), Color = "Meteor Gray" },
                new Car { CarId = 4, Make = "VW", Model = "GTI", Year = new DateTime(2018, 1, 1), Color = "Blue" }
            };
            _carIdIndex = _cars.Count;
        }

        public Car Add(Car car)
        {
            car.CarId = ++_carIdIndex;
            _cars.Add(car);

            return car;
        }

        public Car Update(Car car)
        {
            Car newCarInfo = car;
            Car currentCarInfo = _cars.Where(c => c.CarId == car.CarId).Single();
            int carIndex = _cars.IndexOf(currentCarInfo);

            _cars.RemoveAt(carIndex);
            _cars.Insert(carIndex, newCarInfo);

            return newCarInfo;
        }

        public void Delete(int carId)
        {
            _cars.Remove(Get(carId));
        }

        public List<Car> GetCars()
        {
            return _cars;
        }

        public Car Get(int carId)
        {
            return _cars.Where(c => c.CarId == carId).Single();
        }
    }
}

