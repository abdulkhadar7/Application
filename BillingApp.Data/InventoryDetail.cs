using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BillingApp.Data
{
    [Table("InventoryDetail")]
    public class InventoryDetail
    {
        [Key]
        public int InventoryDetailID { get; set; }

        public int InventoryMasterID { get; set; }

        public int PurchaseDetailID { get; set; }

        public int Quantity { get; set; }

        public int? RowStatus { get; set; }

    }

}
