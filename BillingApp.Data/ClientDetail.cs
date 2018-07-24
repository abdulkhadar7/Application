using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillingApp.Data
{
    [Table("ClientDetail")]
    public class ClientDetail
    {
        [Key]
        public int ClientDetailID { get; set; }
        public int ClientMasterID { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal? SaleAmount { get; set; }
        public decimal? AmountReceived { get; set; }
        public decimal? Credit { get; set; }
        public int? RowStatus { get; set; }

    }
}
