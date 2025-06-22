using Carpass_Profilling.Models;
using Microsoft.EntityFrameworkCore;

namespace Carpass_Profilling.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        // Authentication-related DbSet
        public virtual DbSet<User> Users { get; set; }

        // Application-related DbSets
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Pending> Pendings { get; set; }
        public DbSet<Central_Data> Central_Datas { get; set; }
        public DbSet<Schoolyear> Syear { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User authentication entity configuration
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Email); // Define the primary key

                entity.ToTable("User"); // Define the table name

                // Define properties with their constraints
                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasColumnType("longblob"); // Use longblob for MySQL to store large binary objects
            });


            // Application data configuration
            modelBuilder.Entity<Applicant>().HasKey(a => a.kiosk_Id);
            modelBuilder.Entity<Schoolyear>().HasKey(s => s.Sy_ID);

            modelBuilder.Entity<Pending>()
                .HasOne(p => p.Applicant)
                .WithMany(a => a.Pendings)
                .HasForeignKey(p => p.kiosk_Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Central_Data>()
                .HasOne(cd => cd.Pending)
                .WithMany()
                .HasForeignKey(cd => cd.pending_ID)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Applicant>(entity =>
            {
                entity.Property(e => e.Doc1).HasColumnType("longblob");
                entity.Property(e => e.Doc2).HasColumnType("longblob");
                entity.Property(e => e.Doc3).HasColumnType("longblob");
                entity.Property(e => e.Doc4).HasColumnType("longblob");
                entity.Property(e => e.Doc5).HasColumnType("longblob");
                entity.Property(e => e.Doc6).HasColumnType("longblob");
                entity.Property(e => e.Doc7).HasColumnType("longblob");
            });

            // Seed Data for User table
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Email = "admin@cpu.edu.ph",
                    Name = "CPU Admin",
                    Gender = "Male",
                    Birthday = "1980-01-01",
                    Password = "admin123", // Normally you would hash this in production
                    Role = "Admin"
                }
            );


            // Seed Data for other tables
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
;
        }
    }
}
