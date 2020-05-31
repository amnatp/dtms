﻿using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class ProjectGsin
    {
        public string ProjectCode { get; set; }
        public string Description { get; set; }
        public string Origin { get; set; }
        public int? ProjectLastTruckOrderNumber { get; set; }
        public string TruckOrderPrefix { get; set; }
        public int? MonthlyLastOrderNumber { get; set; }
        public string LastTlpNumber { get; set; }
        public string DefaultTripType { get; set; }
    }
}
