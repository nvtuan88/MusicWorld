using Microsoft.EntityFrameworkCore;

namespace MusicWorld.Models
{
    public class StoreDBContext : DbContext
    {
        public StoreDBContext(DbContextOptions<StoreDBContext> options) : base(options)
        {

        }

        public DbSet<Musics> Musics { get; set; }
    }
}
