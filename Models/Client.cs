using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class Client
    {
        public Client()
        {
            ClientHoliday = new HashSet<ClientHoliday>();
        }

        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public int? LastOrderNumber { get; set; }
        public string TruckOrderPrefix { get; set; }
        public int? MonthlyLastOrderNumber { get; set; }
        public string DefaultTripType { get; set; }
        public string InActive { get; set; }
        public string RateType { get; set; }

        public virtual ICollection<ClientHoliday> ClientHoliday { get; set; }
    }
}
