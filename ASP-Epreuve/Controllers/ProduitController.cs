using ASP_Epreuve.Handlers;
using ASP_Epreuve.Models;
using BLL_Epreuve.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Repositories;
using System.Reflection;

namespace ASP_Epreuve.Controllers
{
    public class ProduitController : Controller
    {
        private readonly IProduitRepository<Produit> _produitRepository;
        private readonly ICategorieRepository<Categorie> _categorieRepository;

        public ProduitController(IProduitRepository<Produit> produitRepository, ICategorieRepository<Categorie> categorieRepository)
        {
            _produitRepository = produitRepository;
            _categorieRepository = categorieRepository;
        }

        // GET: ProduitController
        public ActionResult Index()
        {
            IEnumerable<ProduitListItemViewModel> model = _produitRepository.Get().Select(d => d.ToListItem());
            return View(model);
        }

        // GET: ProduitController/Details/5
        public ActionResult Details(int id)
        {
            ProduitDetailsViewModel model = _produitRepository.Get(id).ToDetails();
            return View(model);
        }

        // GET: ProduitController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProduitController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProduitCreateForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Pas de données reçues");
                if (!ModelState.IsValid) throw new Exception();
                int id = _produitRepository.Insert(form.ToBLL());
                return RedirectToAction(nameof(Details), new { id });
            }
            catch
            {
                return View();
            }
        }

        // GET: ProduitController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                ProduitEditForm model = _produitRepository.Get(id).ToEdit();
                if (model is null) throw new ArgumentOutOfRangeException(nameof(id), $"Pas de film avec l'identifiant {id}");

                return View(model);
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: ProduitController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProduitEditForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Pas de données reçues");
                if (!ModelState.IsValid) throw new Exception();
                _produitRepository.Update(form.ToBLL());
                return RedirectToAction(nameof(Details), new { id });
            }
            catch
            {
                return View(form);
            }
        }

        // GET: ProduitController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                ProduitDeleteViewModel model = _produitRepository.Get(id).ToDelete();
                if (model == null) throw new InvalidDataException();
                return View(model);
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: ProduitController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ProduitDeleteViewModel model)
        {
            try
            {
                _produitRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
    }
}
