namespace BillingApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LedgerMaster")]
    public partial class LedgerMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LedgerMaster()
        {
            LedgerDetails = new HashSet<LedgerDetail>();
        }

        public int LedgerMasterID { get; set; }

        public decimal? TotalAmountReceived { get; set; }

        public decimal? TotalAmountSpent { get; set; }

        public decimal? TotalCredit { get; set; }

        public int ShopID { get; set; }

        public int? RowStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LedgerDetail> LedgerDetails { get; set; }

        public virtual ShopDetail ShopDetail { get; set; }
    }
}
