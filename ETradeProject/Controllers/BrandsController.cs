using ETradeProject.Models;
using ETradeProject.Utilities.WebApiHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETradeProject.Controllers
{
    public class BrandsController : Controller
    {
        // GET: Brands
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllProductCountOfBrand()
        {
            return PartialView("_partialGetAllProductCountOfBrand", ApiManager<ProductCountOfBrand>.GetAll("api/brands/getallproductcountofbrand").Data);
        }
    }
}