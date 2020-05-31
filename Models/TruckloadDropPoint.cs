using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class TruckloadDropPoint
    {
        public TruckloadDropPoint()
        {
            TruckloadDropPointDetail = new HashSet<TruckloadDropPointDetail>();
        }

        public int TruckOrder { get; set; }
        public int DropNumber { get; set; }
        public string Sender { get; set; }
        public string CustomerName { get; set; }
        public string Destination { get; set; }
        public string City { get; set; }
        public decimal? Qty { get; set; }
        public decimal? QtyByCarton { get; set; }
        public decimal? NumberOfOrder { get; set; }
        public decimal? Volume { get; set; }

        public virtual TruckLoad TruckOrderNavigation { get; set; }
        public virtual ICollection<TruckloadDropPointDetail> TruckloadDropPointDetail { get; set; }
    }
}
