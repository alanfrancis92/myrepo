using System;
namespace OrderApp.Model
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string photo { get; set; }
        public decimal price { get; set; }
        public int? category_id { get; set; }
    }
}
