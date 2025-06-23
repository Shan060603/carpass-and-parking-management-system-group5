using Carpass_Profilling.Models;
using Microsoft.EntityFrameworkCore;

namespace Carpass_Profilling.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Pending> Pendings { get; set; }
        public DbSet<Central_Data> Central_Datas { get; set; }
        public DbSet<Schoolyear> Schoolyears { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging(); // For dev only
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // === Table Mapping ===
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Applicant>().ToTable("applicants");
            modelBuilder.Entity<Pending>().ToTable("pendings");
            modelBuilder.Entity<Central_Data>().ToTable("central_datas");
            modelBuilder.Entity<Schoolyear>().ToTable("syear");

            // === User ===
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Email);

                entity.Property(e => e.Name).HasMaxLength(100).IsUnicode(false);
                entity.Property(e => e.Gender).HasMaxLength(100).IsUnicode(false);
                entity.Property(e => e.Birthday).HasMaxLength(100).IsUnicode(false);
                entity.Property(e => e.Email).HasMaxLength(100).IsUnicode(false);
                entity.Property(e => e.Password).HasMaxLength(100).IsUnicode(false);
                entity.Property(e => e.Role).HasMaxLength(10).IsUnicode(false);
                entity.Property(e => e.Image).HasColumnType("longblob");
            });

            // === Applicant ===
            modelBuilder.Entity<Applicant>(entity =>
            {
                entity.HasKey(e => e.kiosk_Id);

                for (int i = 1; i <= 7; i++)
                {
                    entity.Property(typeof(byte[]), $"Doc{i}").HasColumnType("longblob");
                }
            });

            // === Pending ===
            modelBuilder.Entity<Pending>(entity =>
            {
                entity.HasKey(p => p.pending_ID);

                entity.HasOne(p => p.Applicant)
                    .WithMany(a => a.Pendings)
                    .HasForeignKey(p => p.kiosk_Id)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // === Central_Data ===
            modelBuilder.Entity<Central_Data>(entity =>
            {
                entity.HasKey(cd => cd.central_Id);

                entity.HasOne(cd => cd.Pending)
                    .WithMany()
                    .HasForeignKey(cd => cd.pending_ID)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            // === Schoolyear ===
            modelBuilder.Entity<Schoolyear>().HasKey(s => s.Sy_ID);

            // === Seed Data ===
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Email = "admin@cpu.edu.ph",
                    Name = "CPU Admin",
                    Gender = "Male",
                    Birthday = "1980-01-01",
                    Password = "admin123", // Note: Plain text not secure
                    Role = "Admin"
                }
            );

            modelBuilder.Entity<Applicant>().HasData(
                new Applicant
                {
                    kiosk_Id = 1,
                    fullName = "Allen Miguel L. Vargas",
                    type_Applicant = "CPU Student",
                    course_Grade = "BSCS-3",
                    app_Relation = "Student",
                    home_Ad = "Mandurriao",
                    app_Contact = "09456544096",
                    ve_Owner = "Allen Miguel L. Vargas",
                    ve_Relation = "Owner",
                    ve_PlateNO = "FAJ9228",
                    ve_Brand = "Toyota",
                    ve_Type = "Hatchback",
                    ve_Series = "Wigo",
                    ve_Color = "Orange",
                    schoolyear = "2023-2024",
                    facefile_Date = new DateOnly(2024, 5, 28)
                }
            );

            modelBuilder.Entity<Pending>().HasData(
                new Pending
                {
                    pending_ID = 1,
                    kiosk_Id = 1,
                    fullName = "Allen Miguel L. Vargas",
                    type_Applicant = "CPU Student",
                    course_Grade = "BSCS-3",
                    app_Relation = "Student",
                    home_Ad = "Mandurriao",
                    app_Contact = "09454564096",
                    ve_Owner = "Allen Miguel L. Vargas",
                    ve_Relation = "Owner",
                    ve_PlateNO = "FAJ9117",
                    ve_Brand = "Toyota",
                    ve_Type = "Hatchback",
                    ve_Series = "Wigo",
                    ve_Color = "Orange",
                    schoolyear = "2023-2024",
                    facefile_Date = new DateOnly(2024, 5, 28)
                }
            );

            modelBuilder.Entity<Central_Data>().HasData(
                new Central_Data
                {
                    central_Id = 1,
                    pending_ID = 1,
                    fullname = "John Doe",
                    type_applicant = "CPU Student",
                    course_grade = "BSCS-3",
                    app_relation = "Self",
                    home_ad = "123 Main St",
                    app_contact = "123-456-7890",
                    ve_owner = "John Doe",
                    ve_relation = "Owner",
                    ve_plateno = "ABC123",
                    ve_brand = "Toyota",
                    ve_type = "Sedan",
                    ve_series = "Corolla",
                    ve_color = "Blue",
                    schoolyear = "2023-2024",
                    expiration_Date = new DateOnly(2024, 1, 1),
                    sub_Date = new DateOnly(2023, 1, 1),
                    app_Date = new DateOnly(2023, 1, 1)
                }
            );
        }
    }
}
