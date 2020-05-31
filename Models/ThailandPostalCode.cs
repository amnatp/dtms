using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class ThailandPostalCode
    {
        public ThailandPostalCode()
        {
            ClientOrder = new HashSet<ClientOrder>();
            District = new HashSet<District>();
        }

        public string PostalCode { get; set; }

        public virtual ICollection<ClientOrder> ClientOrder { get; set; }
        public virtual ICollection<District> District { get; set; }
    }
}
