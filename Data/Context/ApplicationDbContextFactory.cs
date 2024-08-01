using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Data.Context
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();

            optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=SolarPay_db;Trusted_Connection=True;TrustServerCertificate=True;");

            return new DataContext(optionsBuilder.Options);
        }
    }
}
