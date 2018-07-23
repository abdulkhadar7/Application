namespace BillingApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LedgerDetail
    {
        [Key]
        public int LedgerDetailsID { get; set; }

        public int? LedgerMasterID { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(1)]
        public string TxnType { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int? RowStatus { get; set; }

        public virtual LedgerMaster LedgerMaster { get; set; }
    }
}
