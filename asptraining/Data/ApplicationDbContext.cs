using asptraining.Models;
using Microsoft.EntityFrameworkCore;

namespace asptraining.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Developer> Developer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
 
            modelBuilder.Entity<Developer>().HasData(
              new Developer
              {
                  DevID = 1,
                  DevFirstName = "Aces",
                  DevLastName = "Hapiz",
                  DevMiddleName = "Sumalinog",
                  Specialty = "Full Stack Developer",
                  IsActive = true,
                  HireDate = new DateTime(2020, 1, 15)

              },
                new Developer
                {
                    DevID = 2,
                    DevFirstName = "Maria",
                    DevLastName = "Lopez",
                    DevMiddleName = "Cruz",
                    Specialty = "Backend Developer",
                    IsActive = true,
                    HireDate = new DateTime(2020, 1, 15)
                },
                new Developer
                {
                    DevID = 3,
                    DevFirstName = "John",
                    DevLastName = "Smith",
                    DevMiddleName = "Alexander",
                    Specialty = "Frontend Developer",
                    IsActive = true,
                    HireDate = new DateTime(2020, 1, 15)
                },
                new Developer
                {
                    DevID = 4,
                    DevFirstName = "Sophia",
                    DevLastName = "Johnson",
                    DevMiddleName = "Grace",
                    Specialty = "Mobile App Developer",
                    IsActive = true,
                    HireDate = new DateTime(2020, 1, 15)
                },
                new Developer
                {
                    DevID = 5,
                    DevFirstName = "David",
                    DevLastName = "Kim",
                    DevMiddleName = "Lee",
                    Specialty = "Database Administrator",
                    IsActive = true,
                    HireDate = new DateTime(2020, 1, 15)
                },
                new Developer
                {
                    DevID = 6,
                    DevFirstName = "Emma",
                    DevLastName = "Brown",
                    DevMiddleName = "Claire",
                    Specialty = "UI/UX Designer",
                    IsActive = true,
                    HireDate = new DateTime(2020, 1, 15)
                },
                new Developer
                {
                    DevID = 7,
                    DevFirstName = "Michael",
                    DevLastName = "Garcia",
                    DevMiddleName = "Jose",
                    Specialty = "DevOps Engineer",
                    IsActive = true,
                    HireDate = new DateTime(2020, 1, 15)
                },
                new Developer
                {
                    DevID = 8,
                    DevFirstName = "Olivia",
                    DevLastName = "Martinez",
                    DevMiddleName = "Rose",
                    Specialty = "AI/ML Engineer",
                    IsActive = true,
                    HireDate = new DateTime(2020, 1, 15)
                },
                new Developer
                {
                    DevID = 9,
                    DevFirstName = "James",
                    DevLastName = "Anderson",
                    DevMiddleName = "Paul",
                    Specialty = "Cybersecurity Specialist",
                    IsActive = true,
                    HireDate = new DateTime(2020, 1, 15)
                },
                new Developer
                {
                    DevID = 10,
                    DevFirstName = "Liam",
                    DevLastName = "Wilson",
                    DevMiddleName = "Thomas",
                    Specialty = "Cloud Solutions Architect",
                    IsActive = true,
                    HireDate = new DateTime(2020, 1, 15)
                }
                );
        }
    }
}
