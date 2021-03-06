using ETradeProject.Models;
using ETradeProject.Utilities.WebApiHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ETradeProject.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategories()
        {
            return PartialView("_partialCategories", ApiManager<CategoryModel>.GetAll("api/categories/getall").Data);
        }
    }
}