using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillingApp.Data
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string HSNCode { get; set; }
        public int? RowStatus { get; set; }
    }

}
