using System;
using System.Collections.Generic;

namespace WebInterfaceBd.Models
{
    public partial class Clients
    {
        public string Kola { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public int LichnaKarta { get; set; }
        public string Adress { get; set; }
        public string CreditCard { get; set; }
        public DateTime Data { get; set; }

        public Cars KolaNavigation { get; set; }
    }
}
