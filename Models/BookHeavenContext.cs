using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BookHaven.Models
{
    public partial class BookHeavenContext : DbContext
    {
        public BookHeavenContext()
        {
        }

        public BookHeavenContext(DbContextOptions<BookHeavenContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<InventoryRecord> InventoryRecords { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderItem> OrderItems { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;user=root;database=book_heaven", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.32-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("book");

                entity.HasIndex(e => e.AddedBy, "book_cashier_relationship");

                entity.HasIndex(e => e.SupplierId, "book_supplier_relationship");

                entity.HasIndex(e => e.IsbnNumber, "isbn_number")
                    .IsUnique();

                entity.Property(e => e.BookId)
                    .HasColumnType("int(11)")
                    .HasColumnName("book_id");

                entity.Property(e => e.AddedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("added_by");

                entity.Property(e => e.BookAuthor)
                    .HasMaxLength(255)
                    .HasColumnName("book_author");

                entity.Property(e => e.BookTitle)
                    .HasMaxLength(255)
                    .HasColumnName("book_title");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Genre)
                    .HasColumnType("enum('Fictions','Non-Fictions','Collectibles','Education Materials')")
                    .HasColumnName("genre");

                entity.Property(e => e.IsbnNumber)
                    .HasMaxLength(45)
                    .HasColumnName("isbn_number");

                entity.Property(e => e.Price)
                    .HasPrecision(10)
                    .HasColumnName("price");

                entity.Property(e => e.StockQty)
                    .HasColumnType("int(11)")
                    .HasColumnName("stock_qty");

                entity.Property(e => e.SupplierId)
                    .HasColumnType("int(11)")
                    .HasColumnName("supplier_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("current_timestamp()");

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("book_cashier_relationship");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("book_supplier_relationship");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.HasIndex(e => e.CustomerPhone, "customer_phone")
                    .IsUnique();

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.CustomerPhone)
                    .HasMaxLength(10)
                    .HasColumnName("customer_phone");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(45)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(45)
                    .HasColumnName("last_name");
            });

            modelBuilder.Entity<InventoryRecord>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PRIMARY");

                entity.ToTable("inventory_record");

                entity.HasIndex(e => e.BookId, "inventory_record_book_relationship");

                entity.HasIndex(e => e.AddedBy, "inventory_record_cashier_relationship");

                entity.Property(e => e.RecordId)
                    .HasColumnType("int(11)")
                    .HasColumnName("record_id");

                entity.Property(e => e.AddedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("added_by");

                entity.Property(e => e.BookId)
                    .HasColumnType("int(11)")
                    .HasColumnName("book_id");

                entity.Property(e => e.BoughtFor)
                    .HasPrecision(10)
                    .HasColumnName("bought_for");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Qty)
                    .HasColumnType("int(11)")
                    .HasColumnName("qty");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("current_timestamp()");

                entity.HasOne(d => d.AddedByNavigation)
                    .WithMany(p => p.InventoryRecords)
                    .HasForeignKey(d => d.AddedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("inventory_record_cashier_relationship");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.InventoryRecords)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("inventory_record_book_relationship");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("order");

                entity.HasIndex(e => e.PlacedBy, "order_cashier_relationship");

                entity.HasIndex(e => e.CustomerId, "order_customer_relationship");

                entity.Property(e => e.OrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("order_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.DeliveryAddress)
                    .HasMaxLength(512)
                    .HasColumnName("delivery_address");

                entity.Property(e => e.DeliveryCost)
                    .HasColumnType("int(11)")
                    .HasColumnName("delivery_cost");

                entity.Property(e => e.OrderStatus)
                    .HasColumnType("enum('Pending','Processing','Sent','Fulfilled','Canceled')")
                    .HasColumnName("order_status");

                entity.Property(e => e.OrderType)
                    .HasColumnType("enum('PICKUP','DELIVERY')")
                    .HasColumnName("order_type");

                entity.Property(e => e.PlacedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("placed_by");

                entity.Property(e => e.TotalPrice)
                    .HasPrecision(10)
                    .HasColumnName("total_price");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("current_timestamp()");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("order_customer_relationship");

                entity.HasOne(d => d.PlacedByNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.PlacedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("order_cashier_relationship");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasKey(e => new { e.BookId, e.OrderId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("order_item");

                entity.HasIndex(e => e.OrderId, "order_item_order_relationship");

                entity.Property(e => e.BookId)
                    .HasColumnType("int(11)")
                    .HasColumnName("book_id");

                entity.Property(e => e.OrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("order_id");

                entity.Property(e => e.BoughtPrice)
                    .HasPrecision(10)
                    .HasColumnName("bought_price");

                entity.Property(e => e.Qty)
                    .HasColumnType("int(11)")
                    .HasColumnName("qty");

                entity.Property(e => e.Total)
                    .HasPrecision(10)
                    .HasColumnName("total");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("order_item_book_relationship");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("order_item_order_relationship");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("supplier");

                entity.HasIndex(e => e.SupplierEmail, "supplier_email")
                    .IsUnique();

                entity.HasIndex(e => e.SupplierPhone, "supplier_phone")
                    .IsUnique();

                entity.Property(e => e.SupplierId)
                    .HasColumnType("int(11)")
                    .HasColumnName("supplier_id");

                entity.Property(e => e.SupplierAddress)
                    .HasMaxLength(512)
                    .HasColumnName("supplier_address");

                entity.Property(e => e.SupplierEmail).HasColumnName("supplier_email");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(128)
                    .HasColumnName("supplier_name");

                entity.Property(e => e.SupplierPhone)
                    .HasMaxLength(10)
                    .HasColumnName("supplier_phone");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasIndex(e => e.UserEmail, "user_email")
                    .IsUnique();

                entity.HasIndex(e => e.UserPhone, "user_phone")
                    .IsUnique();

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(45)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(45)
                    .HasColumnName("last_name");

                entity.Property(e => e.PasswordHash)
                    .HasMaxLength(512)
                    .HasColumnName("password_hash");

                entity.Property(e => e.UserEmail).HasColumnName("user_email");

                entity.Property(e => e.UserPhone)
                    .HasMaxLength(10)
                    .HasColumnName("user_phone");

                entity.Property(e => e.UserType)
                    .HasColumnType("enum('CASHIER','ADMIN')")
                    .HasColumnName("user_type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
