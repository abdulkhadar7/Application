using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace BillingApp.Data
{
    [Table("LedgerDetails")]
    public class LedgerDetails
    {
        [Key]
        public int LedgerDetailsID { get; set; }

        public int? LedgerMasterID { get; set; }

        public decimal? Amount { get; set; }

        public string TxnType { get; set; }

        public string Description { get; set; }

        public int? RowStatus { get; set; }

    }

}
