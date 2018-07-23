namespace BillingApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryMaster")]
    public partial class InventoryMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InventoryMaster()
        {
            InventoryDetails = new HashSet<InventoryDetail>();
        }

        public int InventoryMasterID { get; set; }

        public int ProductID { get; set; }

        public int? Quantity { get; set; }

        public int? RowStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryDetail> InventoryDetails { get; set; }

        public virtual Product Product { get; set; }
    }
}
