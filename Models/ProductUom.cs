using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class ProductUom
    {
        public string Storer { get; set; }
        public string ProductCode { get; set; }
        public string Uom { get; set; }
        public decimal? InvQty { get; set; }
        public decimal? SubQty { get; set; }
        public string SubUom { get; set; }
        public DateTime? CreateDate { get; set; }
        public decimal? CreateTime { get; set; }
        public DateTime? ChangeDate { get; set; }
        public decimal? ChangeTime { get; set; }
    }
}
