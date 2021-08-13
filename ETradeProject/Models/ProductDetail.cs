using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ETradeProject.Models
{
    public class ProductDetail : IModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CateogryId { get; set; }
        public string CategoryName { get; set; }
        public int BrandId { get; set; }
        public string WebId { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        private string imagePath;
        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = ConfigurationManager.AppSettings["apiBaseUrl"] + value; }
        }

        public List<ProductImage> Images { get; set; }
        
        public bool Recommended { get; set; }




    }
}