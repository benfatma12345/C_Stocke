using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace C_Stocke.Context
{
    public class GestionStockDbContextFactory : IDesignTimeDbContextFactory<GestionStockDbContext>
    {
        public GestionStockDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<GestionStockDbContext>();
            optionsBuilder.UseSqlite("Data Source=gestionstock.db"); // ou SQL Server selon ton cas

            return new GestionStockDbContext(optionsBuilder.Options);
        }
    }
}
