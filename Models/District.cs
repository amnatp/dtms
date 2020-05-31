using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class District
    {
        public string DistrictCode { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public string AmphurCode { get; set; }
        public string ProvinceCode { get; set; }
        public string PostalCode { get; set; }

        public virtual Amphur AmphurCodeNavigation { get; set; }
        public virtual ThailandPostalCode PostalCodeNavigation { get; set; }
        public virtual Province ProvinceCodeNavigation { get; set; }
    }
}
