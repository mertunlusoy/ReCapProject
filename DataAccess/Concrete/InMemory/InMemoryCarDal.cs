using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1,ColorId = 1, ModelYear = 2022,DailyPrice = 2000,Description = "Volkswagen Passat 2022 Siyah"},
                new Car{Id = 2, BrandId = 1,ColorId = 2,ModelYear = 2022,DailyPrice = 2200,Description = "Volkswagen Passat 2022 Parlament Mavisi"},
                new Car{Id = 3,BrandId = 2,ColorId = 1,ModelYear = 2021,DailyPrice = 1500,Description = "Audi A4 2021 Siyah"},
                new Car{Id = 4,BrandId = 2,ColorId = 3,ModelYear = 2021,DailyPrice = 1700,Description = "Audi A4 2021 Kırmızı"},
                new Car{Id = 5,BrandId = 2,ColorId = 4,ModelYear = 2020,DailyPrice = 1400,Description = "Audi A4 2021 Beyaz"},
                new Car{Id = 6,BrandId = 3,ColorId = 1,ModelYear = 2018,DailyPrice = 900,Description = "Toyota Corolla 2018 Siyah"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => car.Id == c.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => car.Id == p.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
