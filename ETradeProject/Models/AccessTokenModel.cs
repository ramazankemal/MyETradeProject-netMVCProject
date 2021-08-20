using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETradeProject.Models
{
    public class AccessTokenModel:IModel
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}