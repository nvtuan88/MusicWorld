using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public interface IStoreRepository
    {
        IQueryable<Musics> Musics { get; }
        IQueryable<Author> Authors { get; }
        IQueryable<Singer> Singers { get; }
        IQueryable<Album> Albums { get; }

    }
}
