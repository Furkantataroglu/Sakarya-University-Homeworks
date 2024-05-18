using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace Hairdresser_Management_System
{
    public class AppDbContext : DbContext
    {
        // Veritabanı bağlantı dizesini belirtin
        public AppDbContext() : base("name=LocalDatabase")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Service> Services { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
      .HasMany(c => c.Services)
      .WithMany(s => s.Customers)
      .Map(cs =>
      {
          cs.MapLeftKey("CustomerId");
          cs.MapRightKey("ServiceId");
          cs.ToTable("CustomerServices");
      });

            base.OnModelCreating(modelBuilder);
        }
    }


}

