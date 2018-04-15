namespace WebNhom5.Models.Entitis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bill_Details
    {
        public int id { get; set; }

        [StringLength(10)]
        public string id_Product { get; set; }

        public int? id_bill { get; set; }

        public double? total_price { get; set; }

        public int? quantity { get; set; }

        public virtual Bill Bill { get; set; }

        public virtual Product Product { get; set; }
    }
}
