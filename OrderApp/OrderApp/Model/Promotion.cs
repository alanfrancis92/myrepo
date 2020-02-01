using System;
using System.Collections.Generic;

namespace OrderApp.Model
{
    public class Promotion
    {
        public string name { get; set; }
        public int? category_id { get; set; }
        List<Politcs> policies { get; set; }
    }
}
