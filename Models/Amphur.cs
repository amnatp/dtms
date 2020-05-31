using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class Amphur
    {
        public Amphur()
        {
            District = new HashSet<District>();
        }

        public string AmphurCode { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public string ProvinceCode { get; set; }
        public string RegionCode { get; set; }

        public virtual ICollection<District> District { get; set; }
    }
}
