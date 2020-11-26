using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDBContext context;

        public EFStoreRepository(StoreDBContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Musics> Musics => context.Musics;
        public IQueryable<Author> Authors => context.Authors;
        public IQueryable<Album> Albums => context.Albums;
        public IQueryable<Singer> Singers => context.Singers;

    }
}
