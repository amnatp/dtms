using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class TruckloadService
    {
        public int TruckOrder { get; set; }
        public string ServiceType { get; set; }
        public decimal? Revenue { get; set; }
    }
}
