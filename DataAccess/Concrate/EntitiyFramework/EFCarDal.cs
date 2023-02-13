using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntitiyFramework
{
    public class EFCarDal : efEntitiyRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join i in context.Colors
                             on c.ColorId equals i.ColorId
                             join j in context.Brands
                             on c.BrandId equals j.BrandId
                             select new CarDetailDto
                             {
                                 ColorName= i.ColorName,
                                 BrandName= j.BrandName,
                                 DailyPrice=c.DailyPrice,
                                 ModelYear=c.ModelYear
                             };
                return result.ToList();
            };
        }
    }
}
