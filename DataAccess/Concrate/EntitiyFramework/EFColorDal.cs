using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entities.concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntitiyFramework
{
    public class EFColorDal:efEntitiyRepositoryBase<Color,RentACarContext>, IColorDal
    {
    }
}
