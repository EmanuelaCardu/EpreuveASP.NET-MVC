using DAL_Epreuve.Entities;
using DAL_Epreuve.Mappers;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Shared.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
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
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Categorie_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToCategorie();
                        }
                    }
                }
            }
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
