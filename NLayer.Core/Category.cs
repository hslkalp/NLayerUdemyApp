using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        // a category can have more than one product, Navigation property
        public ICollection<Product> Products { get; set; }
    }
}
