using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace BillingApp.Data
{
    
    [Table("InventoryMaster")]
    public class InventoryMaster
    {
        [Key]
        public int InventoryMasterID { get; set; }

        public int ProductID { get; set; }

        public int? Quantity { get; set; }

        public int? RowStatus { get; set; }

    }

}
