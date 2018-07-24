namespace BillingApp.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BillingAppEntities : DbContext
    {
        public BillingAppEntities()
            : base("name=BillingAppEntities")
        {
        }

        public virtual DbSet<ClientDetail> ClientDetails { get; set; }
        public virtual DbSet<ClientMaster> ClientMasters { get; set; }
        public virtual DbSet<InventoryDetail> InventoryDetails { get; set; }
        public virtual DbSet<InventoryMaster> InventoryMasters { get; set; }
        public virtual DbSet<LedgerDetails> LedgerDetails { get; set; }
        public virtual DbSet<LedgerMaster> LedgerMasters { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual DbSet<PurchaseMaster> PurchaseMasters { get; set; }
        public virtual DbSet<SaleDetail> SaleDetails { get; set; }
        public virtual DbSet<SaleMaster> SaleMasters { get; set; }
        public virtual DbSet<ShopDetail> ShopDetails { get; set; }
        public virtual DbSet<ShopMaster> ShopMasters { get; set; }
        public virtual DbSet<SupplierDetail> SupplierDetails { get; set; }
        public virtual DbSet<SupplierMaster> SupplierMasters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientMaster>()
                .Property(e => e.ClientName)
                .IsUnicode(false);

            modelBuilder.Entity<ClientMaster>()
                .Property(e => e.ClientAddress)
                .IsUnicode(false);         

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.HSNCode)
                .IsUnicode(false);

         
            
            modelBuilder.Entity<ShopDetail>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<ShopDetail>()
                .Property(e => e.ShopAddress)
                .IsUnicode(false);

            modelBuilder.Entity<ShopDetail>()
                .Property(e => e.ShopContact)
                .IsUnicode(false);

            modelBuilder.Entity<ShopDetail>()
                .Property(e => e.OtherDetails)
                .IsUnicode(false);

            modelBuilder.Entity<ShopDetail>()
                .Property(e => e.RowStatus)
                .IsUnicode(false);
            
            modelBuilder.Entity<ShopMaster>()
                .Property(e => e.ShopGroupName)
                .IsUnicode(false);

            modelBuilder.Entity<ShopMaster>()
                .Property(e => e.DbName)
                .IsUnicode(false);

            modelBuilder.Entity<ShopMaster>()
                .Property(e => e.GroupDetails)
                .IsUnicode(false);

                 }
    }
}
