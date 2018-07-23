namespace BillingApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SaleDetail")]
    public partial class SaleDetail
    {
        public int SaleDetailID { get; set; }

        public int SaleMasterID { get; set; }

        public int ProductID { get; set; }

        public int? SaleQuantity { get; set; }

        public decimal? SaleAmount { get; set; }

        public int? RowStatus { get; set; }

        public virtual Product Product { get; set; }

        public virtual SaleMaster SaleMaster { get; set; }
    }
}
