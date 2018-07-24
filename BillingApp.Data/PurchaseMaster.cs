using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace BillingApp.Data
{
   
    [Table("PurchaseMaster")]
    public class PurchaseMaster
    {
        [Key]
        public int PurchaseMasterID { get; set; }

        public DateTime PucrahseDate { get; set; }

        public decimal? TotalPurchaseAmount { get; set; }

        public decimal? TotalAmountPaid { get; set; }

        public decimal? TotalCredit { get; set; }

        public int ShopID { get; set; }

        public int? RowStatus { get; set; }

    }
}
