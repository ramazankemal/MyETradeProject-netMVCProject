﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETradeProject.Models
{
    public class ProductCountOfBrand:IModel
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public int ProductCount { get; set; }
    }
}