using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillingApp.Data
{    
    [Table("ClientMaster")]
    public class ClientMaster
    {
        [Key]
        public int ClientMasterID { get; set; }
        public string ClientName { get; set; }
        public int ShopID { get; set; }
        public string ClientAddress { get; set; }
        public decimal? TotalSaleAmount { get; set; }
        public decimal TotalAmountReceived { get; set; }
        public decimal? TotalCredit { get; set; }
        public int? RowStatus { get; set; }

    }

}
