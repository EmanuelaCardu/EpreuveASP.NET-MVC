using ASP_Epreuve.Handlers;
using ASP_Epreuve.Models;
using BLL_Epreuve.Entities;
using Microsoft.AspNetCore.Mvc;
using Shared.Repositories;
using System.Linq;

namespace ASP_Epreuve.Controllers
{
    public class PanierController : Controller
    {
        private readonly IProduitRepository<Produit> _repo;
        private readonly PanierSessionManager _panier;

        public PanierController(IProduitRepository<Produit> repo, PanierSessionManager panier)
        {
            _repo = repo;
            _panier = panier;
        }

        public IActionResult Index()
        {
            IEnumerable<PanierListItemViewModel> model = _panier.GetProduit().Select(d => d.ToPanier());
            return View(model);
        }

        public IActionResult AddToPanier(int id)
        {
            Produit pdt = _repo.Get(id);
            _panier.AddProduit(pdt);
            return RedirectToAction("Index", "produit", new { id = id });
        }

    }
}
