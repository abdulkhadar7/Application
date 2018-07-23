namespace BillingApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientDetail")]
    public partial class ClientDetail
    {
        public int ClientDetailID { get; set; }

        public int ClientMasterID { get; set; }

        public DateTime SaleDate { get; set; }

        public decimal? SaleAmount { get; set; }

        public decimal? AmountReceived { get; set; }

        public decimal? Credit { get; set; }

        public int? RowStatus { get; set; }

        public virtual ClientMaster ClientMaster { get; set; }
    }
}
