using ASP_Epreuve.Handlers;
using BLL_Epreuve.Entities;
using Microsoft.AspNetCore.Mvc;
using Shared.Repositories;

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
            return RedirectToAction(nameof(AddToPanier));
        }

        public IActionResult AddToPanier(int id)
        {
            Produit pdt = _repo.Get(id);
            _panier.AddProduit(pdt);
            return RedirectToAction("details", "produit", new { id = id });
        }

    }
}
