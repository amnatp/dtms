using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class OrderReference
    {
        public string Storer { get; set; }
        public decimal WmspOrder { get; set; }
        public decimal Sequence { get; set; }
        public string RefQualifier { get; set; }
        public string RefValue { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateTime { get; set; }
    }
}
