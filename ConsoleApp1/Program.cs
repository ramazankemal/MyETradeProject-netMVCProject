using ConsoleApp1.Entities;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            Task<WebApiData> wad = pr.GetTodoItem();
            foreach (var item in wad.Result.Data)
            {
                Product pre = item;
            }
        }

        public async Task<WebApiData> GetTodoItem()
        {
            using(HttpClient client=new HttpClient())
            {
                var content = await client.GetStringAsync("https://localhost:44375/api/products/getall");
                WebApiData wad = JsonConvert.DeserializeObject<WebApiData>(content);
                return wad;
            }
        }
    }
}
