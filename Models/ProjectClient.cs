using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class ProjectClient
    {
        public string ProjectCode { get; set; }
        public string ClientId { get; set; }

        public virtual Project ProjectCodeNavigation { get; set; }
    }
}
