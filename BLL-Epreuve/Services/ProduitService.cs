using BLL_Epreuve.Entities;
using BLL_Epreuve.Mappers;
using Shared.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL = DAL_Epreuve.Entities;

namespace BLL_Epreuve.Services
{
    public class ProduitService : IProduitRepository<Produit>
    {
        private readonly IProduitRepository<DAL.Produit> _produitRepository;

        public ProduitService(IProduitRepository<DAL.Produit> produitRepository)
        {
            _produitRepository = produitRepository;
        }


        public void Delete(int id)
        {
            _produitRepository.Delete(id);
        }

        public IEnumerable<Produit> Get()
        {
            return _produitRepository.Get().Select(d => d.ToBLL());
        }

        public Produit Get(int id)
        {
            return _produitRepository.Get(id).ToBLL();
        }

        public int Insert(Produit data)
        {
            return _produitRepository.Insert(data.ToDAL());
        }

        public void Update(Produit data)
        {
            _produitRepository.Update(data.ToDAL());
        }
       

       

        public IEnumerable<Produit> GetByCategorie(string Categorie)
        {
            return _produitRepository.GetByCategorie(Categorie).Select(d => d.ToBLL());
        }

        public Produit Get(string NomProduit)
        {
            return _produitRepository.Get(NomProduit).ToBLL();
        }

        public IEnumerable<Produit> GetByCritereEco(string critereEco)
        {
            return _produitRepository.GetByCritereEco(critereEco).Select(d => d.ToBLL());
        }

        
    }
}
