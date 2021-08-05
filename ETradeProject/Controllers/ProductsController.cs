using ETradeProject.Models;
using ETradeProject.Utilities.WebApiHelper;
using ETradeProject.Utilities.WebApiModels;
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
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
          
            return View(ApiManager<ProductModel>.GetAll("api/products/getall").Data);
        }

        public ActionResult GetCategories()
        {
           return PartialView("_partialCategories", ApiManager<CategoryModel>.GetAll("api/categories/getall").Data);
        }

        public ActionResult GetAllProductCountOfBrand()
        {
            return PartialView("_partialGetAllProductCountOfBrand", ApiManager<ProductCountOfBrand>.GetAll("api/brands/getallproductcountofbrand").Data);
        }
    }
}