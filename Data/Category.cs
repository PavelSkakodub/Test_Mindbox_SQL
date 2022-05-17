using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Mindbox_SQL.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
