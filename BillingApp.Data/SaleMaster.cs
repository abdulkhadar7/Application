namespace BillingApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SaleMaster")]
    public partial class SaleMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SaleMaster()
        {
            SaleDetails = new HashSet<SaleDetail>();
        }

        public int SaleMasterID { get; set; }

        public DateTime SaleDate { get; set; }

        public decimal? TotalSaleAmount { get; set; }

        public decimal? TotalAmountReceived { get; set; }

        public decimal? TotalCredit { get; set; }

        public int ClientMasterID { get; set; }

        public int ShopID { get; set; }

        public int? RowStatus { get; set; }

        public virtual ClientMaster ClientMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleDetail> SaleDetails { get; set; }

        public virtual ShopDetail ShopDetail { get; set; }
    }
}
