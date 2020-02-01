using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using OrderApp.Model;

namespace OrderApp.Service
{
    public class CategoryService
    {
        HttpClient client;
        public CategoryService()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public List<Category> GetCategorys()
        {
            HttpResponseMessage response = client.GetAsync("http://pastebin.com/raw/YNR2rsWe").Result;

            response.EnsureSuccessStatusCode();
            string conteudo =
                response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<List<Category>>(conteudo);
        }
    }
}
