using BLL_Epreuve.Entities;
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
            throw new NotImplementedException();
        }

        public int Insert(Produit data)
        {
            throw new NotImplementedException();
        }

        public void Update(Produit data)
        {
            throw new NotImplementedException();
        }
    }
}
