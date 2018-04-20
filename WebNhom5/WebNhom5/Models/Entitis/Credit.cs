namespace WebNhom5.Models.Entitis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Credit")]
    public partial class Credit
    {
        public int id { get; set; }

        [StringLength(10)]
        public string Id_Role { get; set; }

        [StringLength(10)]
        public string Id_group { get; set; }

        public virtual GroupUser GroupUser { get; set; }

        public virtual Role Role { get; set; }
    }
}
