namespace BillingApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupplierMaster")]
    public partial class SupplierMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SupplierMaster()
        {
            SupplierDetails = new HashSet<SupplierDetail>();
        }

        public int SupplierMasterID { get; set; }

        public int ShopID { get; set; }

        [Required]
        [StringLength(250)]
        public string SupplierName { get; set; }

        public decimal? TotalPurchaseAmount { get; set; }

        public decimal? TotalAmountPaid { get; set; }

        public decimal? TotalCredit { get; set; }

        public decimal? AdvanceAmount { get; set; }

        public int? RowStatus { get; set; }

        public virtual ShopDetail ShopDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierDetail> SupplierDetails { get; set; }
    }
}
