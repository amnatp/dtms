using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class TruckloadCharge
    {
        public int TruckOrder { get; set; }
        public string ChargeType { get; set; }
        public decimal? Revenue { get; set; }
        public decimal? Qty { get; set; }
        public string ChargeUnit { get; set; }

        public virtual TruckLoad TruckOrderNavigation { get; set; }
    }
}
