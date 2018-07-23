namespace BillingApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryDetail")]
    public partial class InventoryDetail
    {
        public int InventoryDetailID { get; set; }

        public int InventoryMasterID { get; set; }

        public int PurchaseDetailID { get; set; }

        public int Quantity { get; set; }

        public int? RowStatus { get; set; }

        public virtual InventoryMaster InventoryMaster { get; set; }

        public virtual PurchaseDetail PurchaseDetail { get; set; }
    }
}
