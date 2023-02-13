using Busines.Abstract;
using Core.DataAccess;
using DataAccess.Abstract;
using Entities.concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines.concrate
{
    public class CarManager : ICarService
    { 
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.CarId == id);
        }

        public List<CarDetailDto> GetCarDetail()
        {
            return _carDal.GetCarDetails();
        }
    }
}
