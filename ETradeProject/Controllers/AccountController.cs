
using ETradeProject.Models;
using ETradeProject.Utilities.WebApiHelper;
using ETradeProject.Utilities.WebApiModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ETradeProject.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Register(UserForRegisterModel userForRegisterModel)
        {

            WebApiDataModel<AccessTokenModel> accessToken = ApiManager<AccessTokenModel>.Login(userForRegisterModel, "api/auth/register");
            if (accessToken.Success)
            {
                AddTokenToCookie(accessToken.Data.Token, accessToken.Data.Expiration, userForRegisterModel.Email);
            }
            return RedirectToAction("Index", "Products");

        }

        [HttpPost]
        public ActionResult Login(UserForLoginModel userForLoginModel)
        {

            WebApiDataModel<AccessTokenModel> accessToken = ApiManager<AccessTokenModel>.Login(userForLoginModel, "api/auth/login");
            if (accessToken.Success)
            {
                AddTokenToCookie(accessToken.Data.Token, accessToken.Data.Expiration, userForLoginModel.Email);
            }
            return RedirectToAction("Index", "Products");

        }

        private void AddTokenToCookie(string token,DateTime expiration,string email)
        {
            HttpCookie cookie = new HttpCookie("token", token);
            cookie.Expires = expiration;
            Response.Cookies.Add(cookie);
            FormsAuthentication.SetAuthCookie(email, false);
        }
    }
}