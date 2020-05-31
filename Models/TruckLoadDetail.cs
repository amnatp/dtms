using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class TruckLoadDetail
    {
        public int TruckOrder { get; set; }
        public int Line { get; set; }
        public string Sender { get; set; }
        public string SenderOrder { get; set; }
        public string ClientId { get; set; }
        public decimal? OrderNumber { get; set; }
        public decimal? OrderLine { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public DateTime? PodReceiveDate { get; set; }
        public DateTime? PodToCustomerDate { get; set; }
        public decimal? DeliveryQuantity { get; set; }
        public string RejectReason { get; set; }
        public decimal? Cbm { get; set; }
        public string Destination { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string RemarkDelivery { get; set; }
        public string Invoice { get; set; }
        public string Incident { get; set; }
        public decimal? ReturnQuantity { get; set; }
        public DateTime? DueDate { get; set; }
        public string CustomerPo { get; set; }
        public string ServiceType { get; set; }
        public string PostalCode { get; set; }
        public string ProductStorer { get; set; }
        public decimal? PickupQty { get; set; }
        public decimal? ActualQuantity { get; set; }
        public DateTime? ClosedDate { get; set; }
        public DateTime? PickupDate { get; set; }
        public string ParcelType { get; set; }
        public string Uom { get; set; }
        public string GsinCode { get; set; }

        public virtual ClientOrderDetail ClientOrderDetail { get; set; }
        public virtual TruckLoad TruckOrderNavigation { get; set; }
    }
}
