using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL = DAL_Epreuve.Entities;
using BLL = BLL_Epreuve.Entities;
using System.Reflection.PortableExecutable;

namespace BLL_Epreuve.Mappers
{
    internal static class Mapper
    {
        public static BLL.Produit ToBLL(this DAL.Produit entity)
        {
            if (entity is null) return null;
            return new BLL.Produit(
                entity.Id_Produit,
                entity.NomProduit,
                entity.Description,
                entity.PrixProduit,
                entity.CritereEco,
                entity.Id_Categorie
                );
        }

        public static BLL.Categorie ToBLL(this DAL.Categorie entity )
        {
            if (entity is null) return null;
            return new BLL.Categorie(
                entity.Id_Categorie,
                entity.Nom,
                entity.Description);
        }


        public static DAL.Produit ToDAL(this BLL.Produit entity)
        {
            if (entity is null) return null;
            return new DAL.Produit()
            {
                Id_Produit = entity.Id_Produit,
                NomProduit = entity.NomProduit,
                Description = entity.Description,
                PrixProduit = entity.PrixProduit,
                CritereEco = entity.CritereEco,
                Id_Categorie = entity.Id_Categorie
            };
        }

        public static DAL.Categorie ToDAL(this BLL.Categorie entity)
        {
            if (entity is null) return null;
            return new DAL.Categorie()
            {
                Id_Categorie = entity.Id_Categorie,
                Nom = entity.Nom,
                Description = entity.Description,
            };
        }





    }
}
