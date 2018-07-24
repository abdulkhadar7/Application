using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace BillingApp.Data
{
    
    [Table("PurchaseDetail")]
    public class PurchaseDetail
    {
        [Key]
        public int PurchaseDetailsID { get; set; }

        public int PurchaseMasterID { get; set; }

        public int ProductID { get; set; }

        public int? PurchaseQuantity { get; set; }

        public decimal? PurchaseAmount { get; set; }

        public decimal? UnitPrice { get; set; }

        public int? RowStatus { get; set; }

    }

}
