using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class Place
    {
        public Place()
        {
            ClientOrder = new HashSet<ClientOrder>();
        }

        public string Name { get; set; }
        public string Tombol { get; set; }
        public string Amphur { get; set; }
        public string Province { get; set; }
        public string Type { get; set; }
        public string ProvinceTh { get; set; }

        public virtual ICollection<ClientOrder> ClientOrder { get; set; }
    }
}
