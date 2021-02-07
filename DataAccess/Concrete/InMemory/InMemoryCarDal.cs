using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
              
               new Car{Id=1,BrandId=2,ColorId=3,DailyPrice=75000,ModelYear=2015, Descriptions="Ford Fiesta"},
               new Car{Id=2,BrandId=2,ColorId=5,DailyPrice=99000,ModelYear=2016, Descriptions="Ford Focus"},
               new Car{Id=3,BrandId=3,ColorId=3,DailyPrice=105000,ModelYear=2016, Descriptions="Seat Leon"},
               new Car{Id=4,BrandId=4,ColorId=1,DailyPrice=110000,ModelYear=2019, Descriptions="Hyundai İ20"},
               new Car{Id=5,BrandId=5,ColorId=2,DailyPrice=100000,ModelYear=2017, Descriptions="Citroen C-Elysse"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);

        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);

            _cars.Remove(carToDelete);

            
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBrand(int BrandId)
        {
          return  _cars.Where(c => c.BrandId == BrandId).ToList();


        }

        public List<Car> GetByColor(int ColorId)
        {
            return _cars.Where(c => c.ColorId == ColorId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descriptions = car.Descriptions;



        }
    }
}
