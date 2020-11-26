using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class Singer
    {
        public int Id { get; set; }

        [Required, StringLength(100), Display(Name ="Singer Name")]
        public string SingerName { get; set; }

        [Required, StringLength(10000), Display(Name = "Singer Description"), DataType(DataType.MultilineText)]
        public string DescriptionSinger { get; set; }

        public virtual ICollection<Musics> Musics { get; set; }
    }
}
