namespace BillingApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShopDetail")]
    public partial class ShopDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShopDetail()
        {
            ClientMasters = new HashSet<ClientMaster>();
            LedgerMasters = new HashSet<LedgerMaster>();
            PurchaseMasters = new HashSet<PurchaseMaster>();
            SaleMasters = new HashSet<SaleMaster>();
            SupplierMasters = new HashSet<SupplierMaster>();
        }

        [Key]
        public int ShopID { get; set; }

        public int ShopMasterID { get; set; }

        [Required]
        [StringLength(128)]
        public string UserID { get; set; }

        public string ShopAddress { get; set; }

        [StringLength(20)]
        public string ShopContact { get; set; }

        [StringLength(250)]
        public string OtherDetails { get; set; }

        [StringLength(250)]
        public string RowStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientMaster> ClientMasters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LedgerMaster> LedgerMasters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseMaster> PurchaseMasters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleMaster> SaleMasters { get; set; }

        public virtual ShopMaster ShopMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierMaster> SupplierMasters { get; set; }
    }
}
