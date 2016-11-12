using Domain.Repository;
using System.Linq;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    /// <summary>
    /// Controller that displays data about products
    /// </summary>
    public class GamesController : Controller
    {
        public IGameRepository _repository;
        public int _pageSize = 4;   //Count of item on 1 page

        public GamesController(IGameRepository _repository)
        {
            this._repository = _repository;
        }

        public ViewResult List(string genre, int page = 1)
        {           
            GamesListViewModel _model = new GamesListViewModel
            {
                Games = _repository.Games
                        .Where(g => genre == null || g.Genre == genre)  //Fiter Item
                        .OrderBy(game => game.GameId)                   //Sort item
                        .Skip((page - 1) * _pageSize)
                        .Take(_pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = _pageSize,
                    TotalItems = genre == null ?
                        _repository.Games.Count() :
                        _repository.Games.Where(game => game.Genre == genre).Count()
                },
                CurrentGenre = genre
            };

            return View(_model);
        }
    }
}