using ETradeProject.Models;
using ETradeProject.Utilities.WebApiModels;
using Newtonsoft.Json;
using PagedList;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

namespace ETradeProject.Utilities.WebApiHelper
{
    public static class ApiManager<T>
        where T : class, IModel, new()

    {

        public static WebApiDataModel<List<T>> GetAll(string url)
        {

            var content = GetContent(url);
            return JsonConvert.DeserializeObject<WebApiDataModel<List<T>>>(content);
           
        }
       
        public static WebApiDataModel<T> Get(string url)
        {
            var content = GetContent(url);
            return JsonConvert.DeserializeObject<WebApiDataModel<T>>(content);
        }

        public static WebApiDataModel<T> Login(IModel model,string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["apiBaseUrl"]);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.PostAsJsonAsync(url, model).Result;
                WebApiDataModel<T> accessToken = null;
                //JsonResult result = new JsonResult();
                if (response.IsSuccessStatusCode)
                {
                    
                    accessToken = JsonConvert.DeserializeObject<WebApiDataModel<T>>(response.Content.ReadAsStringAsync().Result);
                    //result = this.Json(response.Content.ReadAsStringAsync().Result);
                    
                }

                return accessToken;
          
            }
        }

        private static string GetContent(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                return client.GetStringAsync(ConfigurationManager.AppSettings["apiBaseUrl"] + url).Result;
            }
        }
    }
}