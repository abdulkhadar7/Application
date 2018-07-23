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
        public virtual DbSet<LedgerDetail> LedgerDetails { get; set; }
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

            modelBuilder.Entity<ClientMaster>()
                .HasMany(e => e.ClientDetails)
                .WithRequired(e => e.ClientMaster)
                .HasForeignKey(e => e.ClientMasterID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClientMaster>()
                .HasMany(e => e.SaleMasters)
                .WithRequired(e => e.ClientMaster)
                .HasForeignKey(e => e.ClientMasterID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InventoryMaster>()
                .HasMany(e => e.InventoryDetails)
                .WithRequired(e => e.InventoryMaster)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LedgerDetail>()
                .Property(e => e.TxnType)
                .IsUnicode(false);

            modelBuilder.Entity<LedgerDetail>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.HSNCode)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.InventoryMasters)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.PurchaseDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.SaleDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PurchaseDetail>()
                .HasMany(e => e.InventoryDetails)
                .WithRequired(e => e.PurchaseDetail)
                .HasForeignKey(e => e.PurchaseDetailID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PurchaseMaster>()
                .HasMany(e => e.PurchaseDetails)
                .WithRequired(e => e.PurchaseMaster)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SaleMaster>()
                .HasMany(e => e.SaleDetails)
                .WithRequired(e => e.SaleMaster)
                .WillCascadeOnDelete(false);

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

            modelBuilder.Entity<ShopDetail>()
                .HasMany(e => e.ClientMasters)
                .WithRequired(e => e.ShopDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShopDetail>()
                .HasMany(e => e.LedgerMasters)
                .WithRequired(e => e.ShopDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShopDetail>()
                .HasMany(e => e.PurchaseMasters)
                .WithRequired(e => e.ShopDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShopDetail>()
                .HasMany(e => e.SaleMasters)
                .WithRequired(e => e.ShopDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShopDetail>()
                .HasMany(e => e.SupplierMasters)
                .WithRequired(e => e.ShopDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShopMaster>()
                .Property(e => e.ShopGroupName)
                .IsUnicode(false);

            modelBuilder.Entity<ShopMaster>()
                .Property(e => e.DbName)
                .IsUnicode(false);

            modelBuilder.Entity<ShopMaster>()
                .Property(e => e.GroupDetails)
                .IsUnicode(false);

            modelBuilder.Entity<ShopMaster>()
                .HasMany(e => e.ShopDetails)
                .WithRequired(e => e.ShopMaster)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SupplierMaster>()
                .Property(e => e.SupplierName)
                .IsUnicode(false);

            modelBuilder.Entity<SupplierMaster>()
                .HasMany(e => e.SupplierDetails)
                .WithRequired(e => e.SupplierMaster)
                .WillCascadeOnDelete(false);
        }
    }
}
