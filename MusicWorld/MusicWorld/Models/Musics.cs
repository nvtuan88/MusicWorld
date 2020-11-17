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
        public string Description { get; set; }
        public string Image { get; set; }
        public string author { get; set; }
        public string singer { get; set; }
        public string album { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
