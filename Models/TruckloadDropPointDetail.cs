using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class TruckloadDropPointDetail
    {
        public int TruckOrder { get; set; }
        public int DropNumber { get; set; }
        public int Sequence { get; set; }
        public string Sender { get; set; }
        public string SenderOrder { get; set; }
        public string Invoice { get; set; }
        public string CustomerName { get; set; }
        public string Destination { get; set; }
        public string City { get; set; }
        public string IncidentCode { get; set; }
        public string SourceDocumentType { get; set; }
        public string ServiceType { get; set; }
        public string RemarkDelivery { get; set; }
        public DateTime? CustomerReceivedDate { get; set; }
        public DateTime? PodReceivedDate { get; set; }
        public DateTime? PodToSender { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Weight { get; set; }

        public virtual TruckloadDropPoint TruckloadDropPoint { get; set; }
    }
}
