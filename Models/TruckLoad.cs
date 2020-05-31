using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class TruckLoad
    {
        public TruckLoad()
        {
            TruckLoadDetail = new HashSet<TruckLoadDetail>();
            TruckloadCharge = new HashSet<TruckloadCharge>();
            TruckloadDropPoint = new HashSet<TruckloadDropPoint>();
            TruckloadExtracharge = new HashSet<TruckloadExtracharge>();
            TruckloadSenderOrder = new HashSet<TruckloadSenderOrder>();
        }

        public int TruckOrder { get; set; }
        public string Sender { get; set; }
        public string CarLicense { get; set; }
        public string TlpNumber { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string ReferenceNumber { get; set; }
        public string VehicleTypeCode { get; set; }
        public string DriverName { get; set; }
        public string DriverPhone { get; set; }
        public decimal? Cost { get; set; }
        public string TripType { get; set; }
        public decimal? Revenue { get; set; }
        public DateTime? CustomerReceivedDate { get; set; }
        public DateTime? PodReturnDate { get; set; }
        public string Status { get; set; }
        public decimal? Cbm { get; set; }
        public decimal? Weight { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string DeliveryInstruction { get; set; }
        public string Incident { get; set; }
        public DateTime? LoadedDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public string JobType { get; set; }
        public string BillingStatus { get; set; }
        public string AppointmentFlag { get; set; }
        public DateTime? Etd { get; set; }
        public string Project { get; set; }
        public string UserId { get; set; }
        public string ToTrackingSystem { get; set; }
        public string SkyfrogId { get; set; }
        public int? ProjectTruckOrder { get; set; }
        public int? NumberOfDropPoints { get; set; }
        public decimal? TotalQty { get; set; }
        public int? TotalTrip { get; set; }
        public string TransportServiceProvider { get; set; }
        public string GsinCode { get; set; }

        public virtual VehicleType VehicleTypeCodeNavigation { get; set; }
        public virtual ICollection<TruckLoadDetail> TruckLoadDetail { get; set; }
        public virtual ICollection<TruckloadCharge> TruckloadCharge { get; set; }
        public virtual ICollection<TruckloadDropPoint> TruckloadDropPoint { get; set; }
        public virtual ICollection<TruckloadExtracharge> TruckloadExtracharge { get; set; }
        public virtual ICollection<TruckloadSenderOrder> TruckloadSenderOrder { get; set; }
    }
}
