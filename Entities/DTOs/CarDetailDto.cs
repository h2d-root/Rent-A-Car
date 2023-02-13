﻿using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public string BrandName { get; set; }
        public string ModelYear { get; set; }
        public string ColorName { get; set; }
        public int DailyPrice { get; set; }
    }
}
