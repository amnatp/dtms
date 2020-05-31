using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class TripRateChargeDetail
    {
        public string ClientId { get; set; }
        public string OriginId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string DestinationId { get; set; }
        public string VehicleTypeCode { get; set; }
        public string TransportServiceProvider { get; set; }
        public decimal? Price { get; set; }
        public decimal? Cost { get; set; }

        public virtual TripRateChargeHeader TripRateChargeHeader { get; set; }
    }
}
