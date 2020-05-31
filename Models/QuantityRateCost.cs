using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class QuantityRateCost
    {
        public string StorerCode { get; set; }
        public string OriginId { get; set; }
        public string DestinationId { get; set; }
        public string VehicleTypeCode { get; set; }
        public decimal? Price { get; set; }
        public decimal? Cost { get; set; }
    }
}
