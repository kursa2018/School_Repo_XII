using System;
using System.Collections.Generic;

namespace WebAppStokiCatalog.Models
{
    public partial class Distributors
    {
        public Distributors()
        {
            Products = new HashSet<Products>();
        }

        public int DistrId { get; set; }
        public string Name { get; set; }
        public string TelContact { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}
