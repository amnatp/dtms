using System;
using System.Collections.Generic;

namespace dtms.Models
{
    public partial class Product
    {
        public Product()
        {
            ClientOrderDetail = new HashSet<ClientOrderDetail>();
        }

        public string ProductCode { get; set; }
        public string ClientId { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string DivisionCode { get; set; }
        public string ProductType { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ChangedDate { get; set; }
        public string Uom { get; set; }
        public string Barcode { get; set; }
        public decimal? Cbm { get; set; }
        public decimal? Weight { get; set; }
        public string ProductCategory { get; set; }
        public string ProductLifeCycle { get; set; }
        public string CartonSize { get; set; }

        public virtual ICollection<ClientOrderDetail> ClientOrderDetail { get; set; }
    }
}
