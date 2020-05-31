using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class UserRole
    {
        public string UserId { get; set; }
        public string RoleName { get; set; }

        public virtual UserProfile User { get; set; }
    }
}
