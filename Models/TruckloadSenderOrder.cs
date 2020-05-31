using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class TruckloadSenderOrder
    {
        public int TruckOrder { get; set; }
        public int Sequence { get; set; }
        public string ClientId { get; set; }
        public decimal? OrderNumber { get; set; }
        public string Sender { get; set; }
        public string SenderOrder { get; set; }
        public string Invoice { get; set; }
        public string CustomerName { get; set; }
        public string ShipToName { get; set; }
        public string Destination { get; set; }
        public string City { get; set; }
        public string Incident { get; set; }
        public string SourceDocumentType { get; set; }
        public string ServiceType { get; set; }
        public string RemarkDelivery { get; set; }
        public DateTime? CustomerReceivedDate { get; set; }
        public DateTime? PodReceivedDate { get; set; }
        public DateTime? PodToSender { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Weight { get; set; }
        public string SpecialNote { get; set; }
        public int? ShipmentNumber { get; set; }
        public int? TrackingNumber { get; set; }
        public string TrackingCode { get; set; }

        public virtual ClientOrder ClientOrder { get; set; }
        public virtual TruckLoad TruckOrderNavigation { get; set; }
    }
}
