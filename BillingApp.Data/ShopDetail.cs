namespace BillingApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShopDetail")]
    public class ShopDetail
    {
        [Key]
        public int ShopID { get; set; }

        public int ShopMasterID { get; set; }

        public string UserID { get; set; }

        public string ShopAddress { get; set; }

        public string ShopContact { get; set; }

        public string OtherDetails { get; set; }

        public string RowStatus { get; set; }

    }
}
