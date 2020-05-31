using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class Customer
    {
        public Customer()
        {
            ClientOrder = new HashSet<ClientOrder>();
        }

        public string CustomerCode { get; set; }
        public string ClientId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddressLine1 { get; set; }
        public string CustomerAddressLine2 { get; set; }
        public string CustomerAddressLine3 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string CustomerType { get; set; }

        public virtual ICollection<ClientOrder> ClientOrder { get; set; }
    }
}
