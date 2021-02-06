using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            carManager.Add(new Car
            {
                Id = 1,
                BrandId = 1,
                ColorId = 2,
                DailyPrice = 150000,
                ModelYear = 2015,
                Descriptions = "xxx"


            });




        }







    }
}
    

