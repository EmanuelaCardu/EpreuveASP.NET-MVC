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
    public class CategorieService : ICategorieRepository<Categorie>
    {

        private readonly ICategorieRepository<DAL.Categorie> _categorieRepository;

        public CategorieService(ICategorieRepository<DAL.Categorie> categorieRepository)
        {
            _categorieRepository = categorieRepository;
        }
        public void Delete(int id)
        {
            _categorieRepository.Delete(id);
        }

        public IEnumerable<Categorie> Get()
        {
            return _categorieRepository.Get().Select(d => d.ToBLL());
        }

        public Categorie Get(int id)
        {
            return _categorieRepository.Get(id).ToBLL();
        }

        public int Insert(Categorie data)
        {
            return _categorieRepository.Insert(data.ToDAL());
        }

        public void Update(Categorie data)
        {
            _categorieRepository.Update(data.ToDAL());
        }
    }
}
