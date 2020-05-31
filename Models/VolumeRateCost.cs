using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class VolumeRateCost
    {
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Sender { get; set; }
        public string DestinationId { get; set; }
        public decimal? Price { get; set; }
        public decimal? UrgentPrice { get; set; }
        public decimal? Cost { get; set; }
        public string Origin { get; set; }
    }
}
