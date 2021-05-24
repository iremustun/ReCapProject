using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (CarRentalDbContext context = new CarRentalDbContext())
            {
                var result = from c in context.Car
                             join b in context.Brand
                             on c.BrandId equals b.BrandId
                             join cr in context.Color
                             on c.Id equals cr.ColorId
                             select new CarDetailDto
                             {

                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = cr.ColorName

                             };
                return result.ToList();
            }
            
        }

    }
}