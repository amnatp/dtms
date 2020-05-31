using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class OrderEvent
    {
        public string ClientId { get; set; }
        public decimal OrderNumber { get; set; }
        public string EventType { get; set; }
        public DateTime? CreateDate { get; set; }
        public decimal CreateTime { get; set; }
        public DateTime EventDate { get; set; }
        public decimal EventTime { get; set; }
        public string EventDescription { get; set; }
        public DateTime? LocalEventDate { get; set; }
        public decimal? LocalEventTime { get; set; }

        public virtual ClientOrder ClientOrder { get; set; }
    }
}
