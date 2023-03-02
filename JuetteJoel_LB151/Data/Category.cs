using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuetteJoel_LB151.Data
{
    public class Category
    {
        public string categoryName { get; set; }

        public Category() { }
        public Category(string categoryName)
        {
            this.categoryName = categoryName;
        }
    }
}