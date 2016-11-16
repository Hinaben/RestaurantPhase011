namespace RestaurantPhase011.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RestaurantContext : DbContext
    {
        public RestaurantContext()
            : base("name=RestaurantConnectString")
        {
        }

        public virtual DbSet<R_Category> R_Category { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<R_Category>()
                .Property(e => e.CategoryDescription)
                .IsUnicode(false);

            modelBuilder.Entity<R_Category>()
                .HasMany(e => e.Restaurants)
                .WithRequired(e => e.R_Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .Property(e => e.City)
                .IsUnicode(false);
        }
    }
}
