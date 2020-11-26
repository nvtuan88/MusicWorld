using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required, StringLength(100), Display(Name = "Author Name")]
        public string AuthorName { get; set; }

        [Required, StringLength(10000), Display(Name = "Author Description"), DataType(DataType.MultilineText)]
        public string DescriptionAuthor { get; set; }

        public virtual ICollection<Musics> Musics { get; set; }
    }
}
