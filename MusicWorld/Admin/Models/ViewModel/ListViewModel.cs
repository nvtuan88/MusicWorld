using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.ViewModel
{
    public class ListViewModel
    {
        public int ColumnCount { get; set; }
        public IEnumerable<Musics> Musics { get; set; }
        public IEnumerable<Singer> Singers { get; set; }
        public IEnumerable<Album> Albums { get; set; }
        public IEnumerable<Author> Authors { get; set; }
    }
}
