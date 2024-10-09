using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        //ApplicationDbContext()
        //{ }
        public DbSet<CoffeeShop> CoffeeShops { get; set; }

        //public class YourDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
        //{
        //    public ApplicationDbContext CreateDbContext(string[] args)
        //    {
        //        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        //        optionsBuilder.UseSqlServer("Server=.\\MSSQLSERVER_DEV;Database=CoffeeShopDb;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=true");

        //        return new ApplicationDbContext(optionsBuilder.Options);
        //    }

        //}
    }
}
