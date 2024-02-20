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
    public class ProduitService : BaseService, IProduitRepository<Produit>
    {
        public ProduitService(IConfiguration configuration) : base(configuration, "DatabaseEpreuve")
        {
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_Delete";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id_Produit", id);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(id), $"Le produit avec l'identifiant {id} n'est pas das la base de données");
                }
            }
        }

        public IEnumerable<Produit> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToProduit();
                        }
                    }
                }
            }
        }

        public Produit Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_GetById";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id_Produit", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToProduit();
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la base de données.");
                    }
                }
            }
        }

        public int Insert(Produit data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("NomProduit", data.NomProduit);
                    command.Parameters.AddWithValue("Description", data.Description);
                    command.Parameters.AddWithValue("PrixProduit", data.PrixProduit);
                    command.Parameters.AddWithValue("CritereEco", data.CritereEco);
                    command.Parameters.AddWithValue("Categorie", data.Categorie);
                  
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(Produit data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_Update";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Id_Produit", data.Id_Produit);
                    command.Parameters.AddWithValue("NomProduit", data.NomProduit);
                    command.Parameters.AddWithValue("Description", data.Description);
                    command.Parameters.AddWithValue("PrixProduit", data.PrixProduit);
                    command.Parameters.AddWithValue("CritereEco", data.CritereEco);
                    command.Parameters.AddWithValue("Categorie", data.Categorie);

                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(data.Id_Produit), $"L'identifiant {data.Id_Produit} n'est" +
                            $" pas dans la base de donnée");

                }

            }
        }

        public Produit Get(string NomProduit)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_GetByNomProduit";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("NomProduit", NomProduit);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToProduit();
                        throw new ArgumentException(nameof(NomProduit), $"L'identifiant {NomProduit} n'existe pas dans la base de données.");
                    }
                }
            }
        }

        public IEnumerable<Produit> GetByCritereEco(string CritereEco)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_ByCritereEco";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToProduit();
                        }
                    }
                }
            }

        }

        public IEnumerable<Produit> GetByCategorie(string Categorie)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_ByCategorie";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToProduit();
                        }
                    }
                }
            }

        }
    }
}
