using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

namespace MusicWorld.Models
{
    public static class SeedData
    {
        public static void SeedDataMusic(IApplicationBuilder app)
        {
            StoreDBContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDBContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Musics.Any())
            {
                context.Musics.AddRange(
                        new Musics
                        {

                        }
                    );
                context.SaveChanges();
            }
        }
    }
}
