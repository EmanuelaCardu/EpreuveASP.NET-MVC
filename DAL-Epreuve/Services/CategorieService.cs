using DAL_Epreuve.Entities;
using Microsoft.Extensions.Configuration;
using Shared.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Epreuve.Services
{
    public class CategorieService : BaseService, ICategorieRepository<Categorie>
    {
        public CategorieService(IConfiguration configuration) : base(configuration, "DatabaseEpreuve")
        {
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categorie> Get()
        {
            throw new NotImplementedException();
        }

        public Categorie Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Categorie data)
        {
            throw new NotImplementedException();
        }

        public void Update(Categorie data)
        {
            throw new NotImplementedException();
        }
    }
}
