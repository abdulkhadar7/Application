namespace BillingApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchaseMaster")]
    public partial class PurchaseMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseMaster()
        {
            PurchaseDetails = new HashSet<PurchaseDetail>();
        }

        public int PurchaseMasterID { get; set; }

        public DateTime PucrahseDate { get; set; }

        public decimal? TotalPurchaseAmount { get; set; }

        public decimal? TotalAmountPaid { get; set; }

        public decimal? TotalCredit { get; set; }

        public int ShopID { get; set; }

        public int? RowStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }

        public virtual ShopDetail ShopDetail { get; set; }
    }
}
