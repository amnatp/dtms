using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class ThailandLocation
    {
        public int LocationCode { get; set; }
        public string Province { get; set; }
        public string Amphur { get; set; }
        public string Tambol { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string Location { get; set; }
    }
}
