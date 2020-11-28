using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MusicWorld.Infrastructure;
using MusicWorld.Models;

namespace MusicWorld.Pages
{
    public class PlayModel : PageModel
    {
        private IStoreRepository repository;
        public PlayModel(IStoreRepository repo)
        {
            repository = repo;
        }

        public Playlist Playlist { get; set; }
        public string ReturnUrl { get; set; }


        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Playlist = HttpContext.Session.GetJson<Playlist>("playlist") ?? new Playlist();
        }

        public IActionResult OnPost(int musicId, string returnUrl)
        {
            Musics musics = repository.Musics.FirstOrDefault(p => p.Id == musicId);
            Playlist = HttpContext.Session.GetJson<Playlist>("playlist") ?? new Playlist();

            HttpContext.Session.SetJson("playlist", Playlist);
            return RedirectToPage(new { returnUrl = returnUrl });

        }
    }
}
