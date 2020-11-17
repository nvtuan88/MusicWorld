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
    }
}
