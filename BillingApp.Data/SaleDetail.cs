namespace BillingApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SaleDetail")]
    public class SaleDetail
    {
        [Key]
        public int SaleDetailID { get; set; }

        public int SaleMasterID { get; set; }

        public int ProductID { get; set; }

        public int? SaleQuantity { get; set; }

        public decimal? SaleAmount { get; set; }

        public int? RowStatus { get; set; }

    }

}
