using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillingApp.Data
{

    [Table("LedgerMaster")]
    public class LedgerMaster
    {
        [Key]
        public int LedgerMasterID { get; set; }

        public decimal? TotalAmountReceived { get; set; }

        public decimal? TotalAmountSpent { get; set; }

        public decimal? TotalCredit { get; set; }

        public int ShopID { get; set; }

        public int? RowStatus { get; set; }

    }

}
