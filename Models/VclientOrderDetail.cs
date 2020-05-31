using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class VclientOrderDetail
    {
        public string ClientId { get; set; }
        public decimal OrderNumber { get; set; }
        public decimal Line { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public string BatchLot { get; set; }
        public decimal? OrderQty { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Volume { get; set; }
        public DateTime? CreatedDate { get; set; }
        public decimal? CreatedTime { get; set; }
        public DateTime? ChangedDate { get; set; }
        public decimal? ChangedTime { get; set; }
        public decimal? LoadedQty { get; set; }
        public string RecordStatus { get; set; }
        public decimal? DeliveredQty { get; set; }
        public string ProductOwner { get; set; }
        public DateTime? PodEnterDate { get; set; }
        public string PodIdentfication { get; set; }
        public string Uom { get; set; }
    }
}
