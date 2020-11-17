using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class IStoreRepository
    {
        IQueryable<Musics> Musics { get; }
    }
}
