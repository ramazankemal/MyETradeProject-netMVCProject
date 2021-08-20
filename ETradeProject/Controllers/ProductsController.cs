using ETradeProject.Models;
using ETradeProject.Utilities.WebApiHelper;
using ETradeProject.Utilities.WebApiModels;
using Newtonsoft.Json;
using System;
using System.Collections;
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
      
        public ActionResult GetByCategory(int id)
        {
            return View("Index",ApiManager<ProductModel>.GetAll("api/products/getbycategory?categoryid="+id).Data);
        }

        public ActionResult GetByBrand(int id)
        {
            return View("Index", ApiManager<ProductModel>.GetAll("api/products/getbybrand?brandid=" + id).Data);
        }

        public ActionResult GetProductDetails(int id)
        {
            return View("ProductDetails", ApiManager<ProductDetail>.Get("api/products/getproductdetails?productid=" + id).Data);
        }
       
      
        public ActionResult GetRecommendedProducts()
        {
            return PartialView("_partialRecommendedProducts", ApiManager<ProductModel>.GetAll("api/products/getrecommendedproducts").Data);
        }
        
    }
}