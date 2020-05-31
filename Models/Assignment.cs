using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class Assignment
    {
        public int Id { get; set; }
        public int? ResourceLoad { get; set; }
        public int? TaskId { get; set; }
        public int? ResourceId { get; set; }
        public int? Progress { get; set; }
    }
}
