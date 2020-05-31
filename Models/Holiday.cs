using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class Holiday
    {
        public DateTime HolDate { get; set; }
        public int HolYear { get; set; }
        public string HolThdesc { get; set; }
        public string HolEndesc { get; set; }
    }
}
