using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class ProjectUser
    {
        public string ProjectCode { get; set; }
        public string UserId { get; set; }
        public string Active { get; set; }

        public virtual Project ProjectCodeNavigation { get; set; }
        public virtual UserProfile User { get; set; }
    }
}
