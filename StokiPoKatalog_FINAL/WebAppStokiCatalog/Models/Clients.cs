using System;
using System.Collections.Generic;

namespace WebAppStokiCatalog.Models
{
    public partial class Clients
    {
        public Clients()
        {
            Products = new HashSet<Products>();
        }

        public string Egn { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Tel { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}
