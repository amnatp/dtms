using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class ClientHoliday
    {
        public string ClientId { get; set; }
        public DateTime HolidayDate { get; set; }
        public int? HolidayYear { get; set; }
        public string DescriptionEnglish { get; set; }
        public string DescriptionThai { get; set; }

        public virtual Client Client { get; set; }
    }
}
