using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1 , BrandId=1 , ColorId=3 , ModelYear=2016 , DailyPrice=70000 , Description="Spor Araba"},
                new Car{Id=2 , BrandId=2 , ColorId=2 , ModelYear=2018 , DailyPrice=80000 , Description="Hatchback"},
                new Car{Id=3 , BrandId=1 , ColorId=3 , ModelYear=2020 , DailyPrice=95000 , Description="Sedan"},
                new Car{Id=4 , BrandId=2 , ColorId=1 , ModelYear=2017 , DailyPrice=75000 , Description="Hatchback"},
                new Car{Id=5 , BrandId=2 , ColorId=2 , ModelYear=2019 , DailyPrice=90000 , Description="Sedan"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }

       
    }
}
