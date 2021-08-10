using ETradeProject.Models;
using ETradeProject.Utilities.WebApiModels;
using Newtonsoft.Json;
using PagedList;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;

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

        

        public static WebApiDataModel<T> GetById(string url)
        {
            throw new NotImplementedException();
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