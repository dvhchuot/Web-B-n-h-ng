namespace WebNhom5.Models.Entitis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupUser")]
    public partial class GroupUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GroupUser()
        {
            Credits = new HashSet<Credit>();
            UserLogins = new HashSet<UserLogin>();
        }

        [StringLength(10)]
        public string Id { get; set; }

        [StringLength(10)]
        public string name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Credit> Credits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserLogin> UserLogins { get; set; }
    }
}
