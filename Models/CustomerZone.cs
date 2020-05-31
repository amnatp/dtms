using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class CustomerZone
    {
        public string ClientId { get; set; }
        public string ZoneName { get; set; }
        public decimal? WeightTariff { get; set; }
        public decimal? VolumeTariff { get; set; }
        public decimal? QtyTariff { get; set; }
    }
}
