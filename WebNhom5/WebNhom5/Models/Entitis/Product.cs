namespace WebNhom5.Models.Entitis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Bill_Details = new HashSet<Bill_Details>();
            Sales = new HashSet<Sale>();
        }

        [StringLength(10)]
        public string id { get; set; }

        [StringLength(10)]
        public string id_brand { get; set; }

        [StringLength(10)]
        public string id_color { get; set; }

        [StringLength(10)]
        public string id_stype { get; set; }

        [StringLength(20)]
        public string image { get; set; }

        [StringLength(50)]
        public string info { get; set; }

        public double? ole_price { get; set; }

        public double? new_price { get; set; }

        [StringLength(20)]
        public string name { get; set; }

        public DateTime? date_make { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill_Details> Bill_Details { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual Color Color { get; set; }

        public virtual stype stype { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
