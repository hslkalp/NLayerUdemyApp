using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        // EF core auto perceive foreign Key 
        public int CategoryId { get; set; }
        // product have one category
        public Category Category { get; set; }
        public ProductFeature ProductFeature { get; set; }
    }
}
