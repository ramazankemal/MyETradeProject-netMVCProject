using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string WebId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
