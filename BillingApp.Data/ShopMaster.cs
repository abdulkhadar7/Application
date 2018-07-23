namespace BillingApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShopMaster")]
    public partial class ShopMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShopMaster()
        {
            ShopDetails = new HashSet<ShopDetail>();
        }

        public int ShopMasterID { get; set; }

        [StringLength(250)]
        public string ShopGroupName { get; set; }

        [Required]
        [StringLength(250)]
        public string DbName { get; set; }

        [StringLength(250)]
        public string GroupDetails { get; set; }

        public int? RowStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShopDetail> ShopDetails { get; set; }
    }
}
