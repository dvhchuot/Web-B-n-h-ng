namespace WebNhom5.Models.Entitis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sale")]
    public partial class Sale
    {
        [StringLength(10)]
        public string id { get; set; }

        [StringLength(10)]
        public string id_Products { get; set; }

        [StringLength(20)]
        public string info { get; set; }

        public virtual Product Product { get; set; }
    }
}
