using DAL_Epreuve.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Epreuve.Mappers
{
    internal static class Mapper
    {
        public static Produit ToProduit(this IDataRecord record) 
        {
            if (record is null) return null;
            return new Produit()
            {
                Id_Produit = (int)record["Id_Produit"],
                NomProduit = (string)record["NomProduit"],
                Description = (string)record["Description"],
                PrixProduit = (decimal)record["PrixProduit"],
                CritereEco = (string)record["CritereEco"],
                Id_Categorie = (int)record["Id_Categorie"]

            };
        }
        public static Categorie ToCategorie(this IDataRecord record)
        {
            if (record is null) return null;
            return new Categorie()
            {
                Id_Categorie = (int)record["Id_Categorie"],
                Nom = (string)record["Nom"],
                Description = (string)record["Description"]

            };

        }
        public static Commande ToCommande (this IDataRecord record)
        {
            if (record is null) return null;
            return new Commande()
            {
                Id_Commande = (int)record["Id_Commande"],
                Quantite = (int)record["Quantite"],
                Id_Produit = (int)record["Id_Produit"]
            };
        }

        public static Media ToMedia (this IDataRecord record)
        {
            if (record is null) return null;
            return new Media()
            {
                Id_Media = (int)record["Id_Commande"],
                Url = (string)record["Url"],
                Id_Produit = (int)record["Id_Produit"]
            };
        }
    }
}
