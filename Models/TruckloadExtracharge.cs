using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class TruckloadExtracharge
    {
        public int TruckOrder { get; set; }
        public string ChargeType { get; set; }
        public decimal? Revenue { get; set; }

        public virtual TruckLoad TruckOrderNavigation { get; set; }
    }
}
