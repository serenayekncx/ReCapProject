using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetByıD(int id);
        IDataResult<List<Car>> GetAllByColorId(int id);
        IDataResult<List<Car>> GetAllByBrandId(int id);
        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
        

        IDataResult<List<CarDetailDto>> GetCarDetails();



    }
}
