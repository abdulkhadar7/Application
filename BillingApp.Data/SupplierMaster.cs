namespace BillingApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupplierMaster")]
    public class SupplierMaster
    {
        [Key]
        public int SupplierMasterID { get; set; }

        public int ShopID { get; set; }

        public string SupplierName { get; set; }

        public decimal? TotalPurchaseAmount { get; set; }

        public decimal? TotalAmountPaid { get; set; }

        public decimal? TotalCredit { get; set; }

        public decimal? AdvanceAmount { get; set; }

        public int? RowStatus { get; set; }

    }

}
