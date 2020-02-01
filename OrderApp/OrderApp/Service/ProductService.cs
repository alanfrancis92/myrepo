using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using OrderApp.Model;

namespace OrderApp.Service
{
    public class ProductService
    {
        HttpClient client;
        public ProductService()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public List<Product> GetProducts()
        {
            HttpResponseMessage response = client.GetAsync("https://pastebin.com/raw/eVqp7pfX").Result;

            response.EnsureSuccessStatusCode();
            string conteudo =
                response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<List<Product>>(conteudo);
        }
    }
}
