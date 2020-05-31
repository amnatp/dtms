using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class PodHeader
    {
        public DateTime PodToSender { get; set; }
        public string ClientId { get; set; }
        public string PodGroup { get; set; }
    }
}
