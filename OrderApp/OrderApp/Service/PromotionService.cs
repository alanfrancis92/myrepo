using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using OrderApp.Model;

namespace OrderApp.Service
{
    public class PromotionService
    {
        HttpClient client;
        public PromotionService()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public List<Promotion> GetPromotions()
        {
            HttpResponseMessage response = client.GetAsync("https://pastebin.com/raw/R9cJFBtG").Result;

            response.EnsureSuccessStatusCode();
            string conteudo =
                response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<List<Promotion>>(conteudo);
        }
    }
}
