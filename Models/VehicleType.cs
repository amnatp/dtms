using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class VehicleType
    {
        public VehicleType()
        {
            TruckLoad = new HashSet<TruckLoad>();
        }

        public string VehicleTypeCode { get; set; }
        public string VehichleTypeDescription { get; set; }
        public decimal? MaxWeight { get; set; }
        public decimal? MaxVolume { get; set; }

        public virtual ICollection<TruckLoad> TruckLoad { get; set; }
    }
}
