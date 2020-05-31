using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class ClientDefinedZone
    {
        public ClientDefinedZone()
        {
            PlaceClientZoneAssociation = new HashSet<PlaceClientZoneAssociation>();
        }

        public string ZoneId { get; set; }
        public string ShortCode { get; set; }
        public string Description { get; set; }
        public string ClientId { get; set; }

        public virtual ICollection<PlaceClientZoneAssociation> PlaceClientZoneAssociation { get; set; }
    }
}
