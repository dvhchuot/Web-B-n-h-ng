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

        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Bill_Details> Bill_Details { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Credit> Credits { get; set; }
        public virtual DbSet<GroupUser> GroupUsers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<stype> stypes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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

            modelBuilder.Entity<Credit>()
                .Property(e => e.Id_Role)
                .IsUnicode(false);

            modelBuilder.Entity<Credit>()
                .Property(e => e.Id_group)
                .IsUnicode(false);

            modelBuilder.Entity<GroupUser>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<GroupUser>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<GroupUser>()
                .HasMany(e => e.Credits)
                .WithOptional(e => e.GroupUser)
                .HasForeignKey(e => e.Id_group);

            modelBuilder.Entity<GroupUser>()
                .HasMany(e => e.UserLogins)
                .WithOptional(e => e.GroupUser)
                .HasForeignKey(e => e.groupId);

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

            modelBuilder.Entity<Role>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Credits)
                .WithOptional(e => e.Role)
                .HasForeignKey(e => e.Id_Role);

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

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.account)
                .IsUnicode(false);

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.groupId)
                .IsUnicode(false);

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.identification)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.age)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.sex)
                .IsFixedLength();
        }
    }
}
