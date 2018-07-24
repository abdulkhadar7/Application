namespace BillingApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShopMaster")]
    public class ShopMaster
    {
        [Key]
        public int ShopMasterID { get; set; }

        public string ShopGroupName { get; set; }

        public string DbName { get; set; }

        public string GroupDetails { get; set; }

        public int? RowStatus { get; set; }

    }

}
