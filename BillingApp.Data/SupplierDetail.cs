namespace BillingApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupplierDetail")]
    public class SupplierDetail
    {
        [Key]
        public int SupplierDetailID { get; set; }

        public int SupplierMasterID { get; set; }

        public DateTime? PurchaseDate { get; set; }

        public decimal? PurchaseAmount { get; set; }

        public decimal? AmountPaid { get; set; }

        public decimal? CreditAmount { get; set; }

        public int? RowStatus { get; set; }

    }
}
