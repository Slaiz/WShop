using Domain.Model;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    /// <summary>
    /// Controller for cart
    /// </summary>
    public class CartController : Controller
    {
        private IGameRepository _repository;
        public CartController(IGameRepository repository)
        {
            _repository = repository;
        }

        public ViewResult Index(Cart cart, string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }

        public RedirectToRouteResult AddToCart(Cart cart, int gameId, string returnUrl)
        {
            Game game = _repository.Games
                .FirstOrDefault(g => g.GameId == gameId);

            if (game != null)
            {
                cart.AddItem(game, 1);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromCart(Cart cart, int gameId, string returnUrl)
        {
            Game game = _repository.Games
                .FirstOrDefault(g => g.GameId == gameId);

            if (game != null)
            {
                cart.RemoveLine(game);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }

        public PartialViewResult Completed()
        {
            return PartialView();
        }
    }
}