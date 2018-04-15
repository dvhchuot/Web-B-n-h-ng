namespace WebNhom5.Models.Entitis
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShopModel : DbContext
    {
        public ShopModel()
            : base("name=ShopModel")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Bill_Details> Bill_Details { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Direction> Directions { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<stype> stypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Customers)
                .WithOptional(e => e.Account1)
                .HasForeignKey(e => e.account);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Directions)
                .WithOptional(e => e.Account1)
                .HasForeignKey(e => e.account);

            modelBuilder.Entity<Bill>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .HasMany(e => e.Bill_Details)
                .WithOptional(e => e.Bill)
                .HasForeignKey(e => e.id_bill);

            modelBuilder.Entity<Bill_Details>()
                .Property(e => e.id_Product)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Brand>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Brand>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Brand)
                .HasForeignKey(e => e.id_brand);

            modelBuilder.Entity<Color>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Color>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Color)
                .HasForeignKey(e => e.id_color);

            modelBuilder.Entity<Customer>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.identification)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.age)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.account)
                .IsUnicode(false);

            modelBuilder.Entity<Direction>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Direction>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Direction>()
                .Property(e => e.identification)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Direction>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Direction>()
                .Property(e => e.account)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.id_brand)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.id_color)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.id_stype)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Bill_Details)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.id_Product);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Sales)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.id_Products);

            modelBuilder.Entity<Sale>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sale>()
                .Property(e => e.id_Products)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stype>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stype>()
                .Property(e => e.name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<stype>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.stype)
                .HasForeignKey(e => e.id_stype);
        }
    }
}
