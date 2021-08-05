using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    public class WebApiData
    {
        public List<Product> Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}

