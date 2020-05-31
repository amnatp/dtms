using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class UserProfile
    {
        public UserProfile()
        {
            ProjectUser = new HashSet<ProjectUser>();
        }

        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string Password { get; set; }

        public virtual UserRole UserRole { get; set; }
        public virtual ICollection<ProjectUser> ProjectUser { get; set; }
    }
}
