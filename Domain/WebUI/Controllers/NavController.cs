using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    /// <summary>
    /// Сontroller renders navigation menu
    /// </summary>
    public class NavController : Controller
    {
        private IGameRepository _repository;

        public NavController(IGameRepository repository)
        {
            _repository = repository;
        }

        public PartialViewResult Menu(string genre = null)
        {
            ViewBag.SelectedGenre = genre;

            IEnumerable<string> genres = _repository.Games
                .Select(game => game.Genre)
                .Distinct()
                .OrderBy(x => x);

            return PartialView(genres);
        }
    }
}