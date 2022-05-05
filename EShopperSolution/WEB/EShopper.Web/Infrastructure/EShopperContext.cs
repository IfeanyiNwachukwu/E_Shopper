using EShopper.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace EShopper.Web.Infrastructure
{
    public class EShopperContext : DbContext
    {
        public EShopperContext(DbContextOptions<EShopperContext> options):base(options)
        {

        }
        public DbSet<Page> Pages { get; set; }
    }
}
