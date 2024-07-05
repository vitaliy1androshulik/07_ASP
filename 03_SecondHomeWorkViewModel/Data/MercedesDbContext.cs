using _03_SecondHomeWorkViewModel.Entities;
using Microsoft.EntityFrameworkCore;

namespace _03_SecondHomeWorkViewModel.Data
{
    public class MercedesDbContext : DbContext
    {

        public DbSet<Mercedes> Mercedes { get; set; }
        public DbSet<BrandOfCar> BrandOfCars { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=MercedesDb;" +
                "Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
                "TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
                "MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrandOfCar>().HasData(new List<BrandOfCar>()
            {
                new BrandOfCar() {Id=1, Name="Mercedes-Benz" },
                new BrandOfCar() {Id=2, Name="Mercedes-AMG" }
            });
            modelBuilder.Entity<Mercedes>().HasData(new List<Mercedes>()
            {
                new Mercedes() {Id=1, BrandOfCarId=1, Model="E450 4MATIC", Class="E-Class",
                Price=3735256, Discount=2, HorsePower=375, Volume=3.0, Year=2024},
                new Mercedes() {Id=2, BrandOfCarId=1, Model="E 220 d", Class="E-Class",
                Price=2823744, Discount=5, HorsePower=194, Volume=2.0, Year=2024},
                new Mercedes() {Id=3, BrandOfCarId=1, Model="A 180", Class="A-Class",
                Price=1998166, Discount=2, HorsePower=136, Volume=1.95, Year=2024},
                new Mercedes() {Id=4, BrandOfCarId=2, Model="A 35 AMG 4MATIC", Class="A-Class",
                Price=2794320, Discount=0, HorsePower=306, Volume=2.0, Year=2024},
                new Mercedes() {Id=5, BrandOfCarId=1, Model="C 180", Class="C-Class",
                Price=2148646, Discount=15, HorsePower=168, Volume=1.5, Year=2024},
            });
        }
    }

}
