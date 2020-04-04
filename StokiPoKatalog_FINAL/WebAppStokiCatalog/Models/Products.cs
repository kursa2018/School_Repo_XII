using System;
using System.Collections.Generic;

namespace WebAppStokiCatalog.Models
{
    public partial class Products
    {
        public string Clients { get; set; }
        public int Distributors { get; set; }
        public int Number { get; set; }
        public string Naimenovanie { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public DateTime Data { get; set; }

        public Clients ClientsNavigation { get; set; }
        public Distributors DistributorsNavigation { get; set; }
    }
}
