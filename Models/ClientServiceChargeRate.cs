using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class ClientServiceChargeRate
    {
        public string ClientId { get; set; }
        public string ServiceChargeCode { get; set; }
        public decimal? Rate { get; set; }
        public string VehicleTypeCode { get; set; }
        public string Destination { get; set; }
        public string Description { get; set; }
        public decimal? Cost { get; set; }
        public string Vendor { get; set; }
    }
}
