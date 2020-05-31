using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class PlaceClientZoneAssociation
    {
        public string Name { get; set; }
        public string ZoneId { get; set; }
        public string ClientId { get; set; }

        public virtual ClientDefinedZone Zone { get; set; }
    }
}
