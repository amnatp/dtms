using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class ClientOrder
    {
        public ClientOrder()
        {
            ClientOrderDetail = new HashSet<ClientOrderDetail>();
            OrderDateNavigation = new HashSet<OrderDate>();
            OrderEvent = new HashSet<OrderEvent>();
            TruckloadSenderOrder = new HashSet<TruckloadSenderOrder>();
        }

        public decimal OrderNumber { get; set; }
        public string ClientId { get; set; }
        public string SenderOrder { get; set; }
        public string CustomerPo { get; set; }
        public string Invoice { get; set; }
        public string AppointmentFlag { get; set; }
        public string CustomerPickup { get; set; }
        public string Status { get; set; }
        public string Destination { get; set; }
        public string ShipToName1 { get; set; }
        public string ShipToName2 { get; set; }
        public string ShipToName3 { get; set; }
        public string ShipToAddress1 { get; set; }
        public string ShipToAddress2 { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToState { get; set; }
        public string ShipToPostalCode { get; set; }
        public string ShipToCountryCode { get; set; }
        public decimal? NumberOfOrderLines { get; set; }
        public decimal? TotalShippedQty { get; set; }
        public decimal? TotalVolume { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string OrderType { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? RevisedDueDate { get; set; }
        public DateTime? PickAssignedDate { get; set; }
        public string RemarkDelivery { get; set; }
        public string RevisedDueDateReason { get; set; }
        public DateTime? LoadedDate { get; set; }
        public string CustomerCode { get; set; }
        public DateTime? CustomerReceivedDate { get; set; }
        public DateTime? CancelledDate { get; set; }
        public DateTime? PodToSender { get; set; }
        public DateTime? PodReceivedDate { get; set; }
        public string Incident { get; set; }
        public string TermOfPayment { get; set; }
        public string DeliveryStatus { get; set; }
        public DateTime? DueDate { get; set; }
        public string ServiceType { get; set; }
        public string ClientCustomerId { get; set; }
        public string PodGroup { get; set; }
        public DateTime? PodEnterDate { get; set; }
        public string Sender { get; set; }
        public decimal? CreateTime { get; set; }
        public int? NumberOfShipment { get; set; }
        public string ToBeRemoved { get; set; }
        public DateTime? TruckBookingDate { get; set; }
        public string PickupType { get; set; }
        public string RecordSource { get; set; }
        public DateTime? ReleaseToPickDate { get; set; }
        public DateTime? ConfirmShipDate { get; set; }
        public string ApllRemark { get; set; }
        public string TransportZone { get; set; }
        public string Po { get; set; }
        public string Gsin { get; set; }

        public virtual Customer C { get; set; }
        public virtual Place DestinationNavigation { get; set; }
        public virtual ThailandPostalCode ShipToPostalCodeNavigation { get; set; }
        public virtual ICollection<ClientOrderDetail> ClientOrderDetail { get; set; }
        public virtual ICollection<OrderDate> OrderDateNavigation { get; set; }
        public virtual ICollection<OrderEvent> OrderEvent { get; set; }
        public virtual ICollection<TruckloadSenderOrder> TruckloadSenderOrder { get; set; }
    }
}
