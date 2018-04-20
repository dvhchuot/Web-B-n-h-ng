namespace WebNhom5.Models.Entitis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserLogin")]
    public partial class UserLogin
    {
        [Key]
        [StringLength(50)]
        public string account { get; set; }

        [StringLength(10)]
        public string groupId { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string address_ship { get; set; }

        [StringLength(11)]
        public string phone { get; set; }

        [StringLength(11)]
        public string identification { get; set; }

        [StringLength(20)]
        public string email { get; set; }

        [StringLength(3)]
        public string age { get; set; }

        [StringLength(3)]
        public string sex { get; set; }

        public virtual GroupUser GroupUser { get; set; }
    }
}
