using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class VolumeRateChargeHeader
    {
        public string Sender { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
