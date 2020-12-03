using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class Musics
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public int? AuthorId { get; set; }
        public virtual Author Authors { get; set; }


        public int? SingerId { get; set; }
        public virtual Singer Singers{ get; set; }

        public int? AlbumId { get; set; }
        public virtual Album Albums { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
