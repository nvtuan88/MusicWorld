using Microsoft.EntityFrameworkCore;

namespace MusicWorld.Models
{
    public class StoreDBContext : DbContext
    {
        public StoreDBContext(DbContextOptions<StoreDBContext> options) : base(options)
        {

        }

        public DbSet<Musics> Musics { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Singer> Singers { get; set; }
        public DbSet<Album> Albums { get; set; }
    }
}
