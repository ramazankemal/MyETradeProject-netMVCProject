using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETradeProject.Utilities.WebApiModels
{
    public class WebApiModel:IWebApiModel
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}