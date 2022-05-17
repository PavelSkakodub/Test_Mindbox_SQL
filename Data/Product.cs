using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Mindbox_SQL.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public List<Category> Categories { get; set; }
    }
}
