using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class ClientServiceRateCharge
    {
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ClientId { get; set; }
        public string ServiceChargeCode { get; set; }
        public string TransportServiceProvider { get; set; }
        public string OriginId { get; set; }
        public string DestinationId { get; set; }
        public string VehicleTypeCode { get; set; }
        public string Description { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Cost { get; set; }
    }
}
