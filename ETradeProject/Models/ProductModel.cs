using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ETradeProject.Models
{
    public class ProductModel:IModel
    {
        public int ID { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string WebId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        private string imagePath;
        public string ImagePath 
        {
            get { return ConfigurationManager.AppSettings["apiBaseUrl"] + imagePath; }
            set { imagePath =  value; }
        }
        public bool Recommended { get; set; }
    }
}