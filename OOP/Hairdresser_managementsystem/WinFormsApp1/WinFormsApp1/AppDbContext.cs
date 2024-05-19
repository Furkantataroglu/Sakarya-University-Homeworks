using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentService> AppointmentServices { get; set; }
        public DbSet<Personnel> Personnel { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;");
            //string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DatabaseName.mdf");
            //string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True;Connect Timeout=30";
            //optionsBuilder.UseSqlServer(connectionString);

            // Proje dizininde SQLite dosyasının yolunu ayarla
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "YourDatabase.db");
            optionsBuilder.UseSqlite($"Data Source={path}");



        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
            .HasOne(a => a.Customer)
            .WithMany(c => c.Appointments)
            .HasForeignKey(a => a.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Personnel)
                .WithMany()
                .HasForeignKey(a => a.PersonnelId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AppointmentService>()
                .HasOne(a => a.Appointment)
                .WithMany(a => a.AppointmentServices)
                .HasForeignKey(a => a.AppointmentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AppointmentService>()
                .HasOne(a => a.Service)
                .WithMany()
                .HasForeignKey(a => a.ServiceId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
