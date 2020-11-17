using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        public string Image { get; set; }

        [Required, StringLength(100), Display(Name ="Album Name")]
        public string AlbumName { get; set; }

        public virtual Musics Musics { get; set; }
    }
}
