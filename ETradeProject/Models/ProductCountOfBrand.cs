﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETradeProject.Models
{
    public class ProductCountOfBrand:IModel
    {
        public string Name { get; set; }
        public int ProductCount { get; set; }
    }
}