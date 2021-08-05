using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETradeProject.Utilities.WebApiModels
{
    public class WebApiDataModel<T>:WebApiModel, IWebApiModel
    {
        public T Data { get; set; }
    }
}