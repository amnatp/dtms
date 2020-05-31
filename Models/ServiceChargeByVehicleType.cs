using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class ServiceChargeByVehicleType
    {
        public string ClientId { get; set; }
        public string ChargeCode { get; set; }
        public string VehicleTypeCode { get; set; }
        public decimal? Rate { get; set; }
        public string Deecription { get; set; }
    }
}
