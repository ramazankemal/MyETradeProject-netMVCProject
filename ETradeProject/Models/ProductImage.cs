using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ETradeProject.Models
{
    public class ProductImage:IModel
    {
        public int ID { get; set; }
        public int ProductId { get; set; }

        private string imagePath;
        public string ImagePath
        {
            get { return ConfigurationManager.AppSettings["apiBaseUrl"] + imagePath; }
            set { imagePath = value; }
        }
    }
}