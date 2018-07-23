namespace BillingApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchaseDetail")]
    public partial class PurchaseDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseDetail()
        {
            InventoryDetails = new HashSet<InventoryDetail>();
        }

        [Key]
        public int PurchaseDetailsID { get; set; }

        public int PurchaseMasterID { get; set; }

        public int ProductID { get; set; }

        public int? PurchaseQuantity { get; set; }

        public decimal? PurchaseAmount { get; set; }

        public decimal? UnitPrice { get; set; }

        public int? RowStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryDetail> InventoryDetails { get; set; }

        public virtual Product Product { get; set; }

        public virtual PurchaseMaster PurchaseMaster { get; set; }
    }
}
