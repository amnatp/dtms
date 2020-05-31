using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class OrderNote
    {
        public decimal OrderNumber { get; set; }
        public decimal Sequence { get; set; }
        public string NoteType { get; set; }
        public string NoteValue { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ChangedDate { get; set; }
        public string ClientId { get; set; }
    }
}
