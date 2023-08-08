using Microsoft.EntityFrameworkCore;

namespace ANKSuperMarket.Data
{
    public class MarketDbContext : DbContext
    {

        public MarketDbContext(DbContextOptions<MarketDbContext> options) :base(options)
        {

        }
        public DbSet<Urun> Urunler => Set<Urun>();
    }
    
}
