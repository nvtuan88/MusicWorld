using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MusicWorld.Models;
using MusicWorld.Models.ViewModel;

namespace MusicWorld.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
                => View(new ListViewModel
                {
                    Musics = repository.Musics,
                    Singers = repository.Singers,
                    Albums = repository.Albums,
                    Authors = repository.Authors
                });

        public ViewResult Albums()
        => View(new ListViewModel
        {
            Albums = repository.Albums,
        });
        public ViewResult Author()
        => View(new ListViewModel
        {
            Authors = repository.Authors,
        });
        public ViewResult Musics()
        => View(new ListViewModel
        {
            Musics = repository.Musics,
        });
        public ViewResult News()
        {
            return View();
        }
        public ViewResult Singers()
        => View(new ListViewModel
        {
            Singers = repository.Singers,
        });

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
