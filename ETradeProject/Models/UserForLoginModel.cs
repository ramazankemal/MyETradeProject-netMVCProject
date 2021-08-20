using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETradeProject.Models
{
    public class UserForLoginModel:IModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}