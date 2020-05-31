using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class ReceiptEntity
    {
        public decimal ReceiptNumber { get; set; }
        public string CustomerCode { get; set; }
        public string ShipToName1 { get; set; }
        public string ShipToName2 { get; set; }
        public string ShipToName3 { get; set; }
        public string ShipToAddress1 { get; set; }
        public string ShipToAddress2 { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToPostalCode { get; set; }
        public string ShipToCountry { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ChangedDate { get; set; }
        public string ClientId { get; set; }
    }
}
