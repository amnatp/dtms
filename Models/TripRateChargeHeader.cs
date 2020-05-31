using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class TripRateChargeHeader
    {
        public TripRateChargeHeader()
        {
            TripRateChargeDetail = new HashSet<TripRateChargeDetail>();
        }

        public string ClientId { get; set; }
        public string OriginId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<TripRateChargeDetail> TripRateChargeDetail { get; set; }
    }
}
