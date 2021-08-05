using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETradeProject.Models
{
    public class CategoryModel:IModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}