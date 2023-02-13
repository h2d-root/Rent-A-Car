using Entities.concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int id);
        public void AddCar(Car car);
        List<CarDetailDto> GetCarDetail();
    }
}
