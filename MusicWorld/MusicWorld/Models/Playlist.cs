using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class Playlist
    {
        public List<PlayLine> Lines { get; set; } = new List<PlayLine>();

        public void AddItem(Musics musics)
        {
            PlayLine line = Lines
                .Where(p => p.Musics.Id == musics.Id)
                .FirstOrDefault();
            if(line == null)
            {
                Lines.Add(new PlayLine
                { Musics = musics}
                    );
            }
        }
        public void RemoveLine(Musics musics) => Lines.RemoveAll(l => l.Musics.Id == musics.Id);
    }

    

    public class PlayLine
    {
        public int PlayLineID { get; set; }
        public Musics Musics { get; set; }
    }
}
