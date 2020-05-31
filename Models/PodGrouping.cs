using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class PodGrouping
    {
        public string ClientId { get; set; }
        public string PodGroup { get; set; }
        public DateTime? PodToSender { get; set; }
    }
}
