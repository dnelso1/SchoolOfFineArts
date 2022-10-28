using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SchoolOfFineArtsModels;

namespace SchoolOfFineArtsDB
{
    public class SchoolOfFineArtsDbContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }


        public SchoolOfFineArtsDbContext()
        {

        }

        public SchoolOfFineArtsDbContext(DbContextOptions options)
            : base(options)
        {

        }

        //add to allow migrations when the context is not built
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                var config = builder.Build();
                var cnstr = config["ConnectionStrings:SchoolOfFineArtsDB"];
                var options = new DbContextOptionsBuilder<SchoolOfFineArtsDbContext>().UseSqlServer(cnstr);
                optionsBuilder.UseSqlServer(cnstr);
            }
        }

        //Add to seed data:
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>(x =>
            {
                x.HasData(
                    new Teacher() { Id = 1, FirstName = "Anne", LastName = "Sullivan", Age = 27 },
                    new Teacher() { Id = 2, FirstName = "Maria", LastName = "Montessori", Age = 32 },
                    new Teacher() { Id = 3, FirstName = "William", LastName = "McGuffey", Age = 21 },
                    new Teacher() { Id = 4, FirstName = "Emma", LastName = "Willard", Age = 47 },
                    new Teacher() { Id = 5, FirstName = "Jaime", LastName = "Escalante", Age = 62 }
                );
            });

            var seedDate = new DateTime(1984, 1, 1);
            modelBuilder.Entity<Student>(x =>
            {
                x.HasData(
                    new Student() { Id = 1, FirstName = "Greg", LastName = "John", DateOfBirth = seedDate },
                    new Student() { Id = 2, FirstName = "Erik", LastName = "Tabaka", DateOfBirth = seedDate },
                    new Student() { Id = 3, FirstName = "Josh", LastName = "Benson", DateOfBirth = seedDate },
                    new Student() { Id = 4, FirstName = "Alex", LastName = "Robinson", DateOfBirth = seedDate },
                    new Student() { Id = 5, FirstName = "Mark", LastName = "Rimbaugh", DateOfBirth = seedDate }
                );
            });

            modelBuilder.Entity<Course>(x =>
            {
                //x.HasData(
                //    new Course() { Id = 1, Name = "Humanities 101", Abbreviation = "HUM101", Department = seedDate },
                //    new Course() { Id = 2, Name = "Erik", Abbreviation = "Tabaka", Department = seedDate },
                //    new Course() { Id = 3, Name = "Josh", Abbreviation = "Benson", Department = seedDate },
                //    new Course() { Id = 4, Name = "Alex", Abbreviation = "Robinson", Department = seedDate },
                //    new Course() { Id = 5, Name = "Mark", Abbreviation = "Rimbaugh", Department = seedDate }
                //);
            });
        }
    }
}