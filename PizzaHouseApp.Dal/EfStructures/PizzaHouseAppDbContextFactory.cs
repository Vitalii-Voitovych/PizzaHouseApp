using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PizzaHouseApp.Dal.EfStructures
{
    public class PizzaHouseAppDbContextFactory :
        IDesignTimeDbContextFactory<PizzaHouseAppDbContext>
    {
        public PizzaHouseAppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PizzaHouseAppDbContext>();
            var connectionString = @"Data Source=(localdb)\mssqllocaldb;Integrated Security=true;Initial Catalog=PizzaHouseDb";
            optionsBuilder.UseSqlServer(connectionString);
            return new PizzaHouseAppDbContext(optionsBuilder.Options);
        }
    }
}
