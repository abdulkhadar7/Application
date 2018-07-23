namespace BillingApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientMaster")]
    public partial class ClientMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClientMaster()
        {
            ClientDetails = new HashSet<ClientDetail>();
            SaleMasters = new HashSet<SaleMaster>();
        }

        [Key]
        [Column("ClientMaster")]
        public int ClientMaster1 { get; set; }

        [Required]
        [StringLength(250)]
        public string ClientName { get; set; }

        public int ShopID { get; set; }

        public string ClientAddress { get; set; }

        public decimal? TotalSaleAmount { get; set; }

        public decimal TotalAmountReceived { get; set; }

        public decimal? TotalCredit { get; set; }

        public int? RowStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientDetail> ClientDetails { get; set; }

        public virtual ShopDetail ShopDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleMaster> SaleMasters { get; set; }
    }
}
