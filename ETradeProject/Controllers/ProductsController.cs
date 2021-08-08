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
          
            return View();
        }

        public ActionResult GetAllProduct()
        {
            return PartialView("_partialGetAllProduct", ApiManager<ProductModel>.GetAll("api/products/getall").Data);
        }
      
        public ActionResult GetRecommendedProducts()
        {
            List<ProductModel> recommendedProducts = ApiManager<ProductModel>.GetAll("api/products/getrecommendedproducts").Data;          

            return PartialView("_partialRecommendedProducts", GroupProducts(recommendedProducts));
        }

        // ()=list<product>
        // *=product
        // { (***), (***), (**) }
        private List<IEnumerable> GroupProducts(List<ProductModel> recommendedProducts)
        {
            List<IEnumerable> productsGroupList = new List<IEnumerable>();
            List<ProductModel> products = null;
            foreach (var item in recommendedProducts.Select((value, index) => (value, index)))
            {
                if (products == null)
                    products = new List<ProductModel>();

                products.Add(item.value);
                if (products.Count == 3 || recommendedProducts.Count - 1 == item.index)
                {
                    productsGroupList.Add(products);
                    products = null;
                }
            }

            return productsGroupList;
        }
    }
}