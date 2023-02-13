using Entities.concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetById(int id);
    }
}
