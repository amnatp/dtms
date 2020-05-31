using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class VOrderInformation
    {
        public string ClientId { get; set; }
        public string SenderOrder { get; set; }
        public decimal OrderNumber { get; set; }
        public string RemarkDelivery { get; set; }
        public DateTime? ReleaseToPickDate { get; set; }
        public DateTime? LoadedDate { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Status { get; set; }
        public string CustomerPickup { get; set; }
        public DateTime? CustomerReceivedDate { get; set; }
        public DateTime? CancelledDate { get; set; }
        public DateTime? PickAssignedDate { get; set; }
        public string CustomerName { get; set; }
        public string ShipToName1 { get; set; }
        public decimal? TotalVolume { get; set; }
        public string OrderType { get; set; }
        public DateTime? PodReceivedDate { get; set; }
        public string Destination { get; set; }
        public DateTime? PodToSender { get; set; }
        public string Invoice { get; set; }
        public DateTime? ConfirmShipDate { get; set; }
        public string TripType { get; set; }
        public string Incident { get; set; }
        public string AppointmentFlag { get; set; }
        public string Project { get; set; }
        public string UserId { get; set; }
        public decimal? TotalQty { get; set; }
    }
}
