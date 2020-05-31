using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class OrderDate
    {
        public decimal OrderNumber { get; set; }
        public string DateType { get; set; }
        public string ClientId { get; set; }
        public DateTime? DateTypeDate { get; set; }
        public decimal? DateTypeTime { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ChangedDate { get; set; }

        public virtual ClientOrder ClientOrder { get; set; }
    }
}
