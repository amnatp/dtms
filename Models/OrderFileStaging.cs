using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class OrderFileStaging
    {
        public string DocumentNumber { get; set; }
        public string ClientId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }
        public string Reference { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public decimal Qty { get; set; }
        public DateTime OrderDate { get; set; }
        public string PostalCode { get; set; }
        public string Destination { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string District { get; set; }
        public string OrderType { get; set; }
        public DateTime? LoadedDate { get; set; }
        public string Remark { get; set; }
        public decimal? LoadedQty { get; set; }
        public decimal? ActualQty { get; set; }
        public DateTime? CustomerReceivedDate { get; set; }
        public DateTime? PodReceivedDate { get; set; }
        public DateTime? PodToSender { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Weight { get; set; }
        public DateTime? DueDate { get; set; }
        public string CustomerPickup { get; set; }
        public string Sender { get; set; }
        public string IsImportedToOrder { get; set; }
        public string ShipToName { get; set; }
        public string Invoice { get; set; }
        public string ServiceType { get; set; }
    }
}
