using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntitiyFramework
{
    public class EFBrandDal:efEntitiyRepositoryBase<Brand, RentACarContext>, IBrandDal
    {
    }
}
