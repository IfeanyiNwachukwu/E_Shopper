using Microsoft.EntityFrameworkCore;

namespace EShopper.Web.Infrastructure
{
    public class EShopperContext : DbContext
    {
        public EShopperContext(DbContextOptions<EShopperContext> options):base(options)
        {

        }
    }
}
