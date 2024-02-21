﻿using ASP_Epreuve.Models;
using BLL_Epreuve.Entities;

namespace ASP_Epreuve.Handlers
{
    public static class Mapper
    {
        public static ProduitListItemViewModel ToListItem(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitListItemViewModel
            {
                Id_Produit = entity.Id_Produit,
                NomProduit = entity.NomProduit,
                Description = entity.Description,
            };
        }

        public static ProduitDetailsViewModel ToDetails(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitDetailsViewModel
            {
                Id_Produit =entity.Id_Produit,
                NomProduit =entity.NomProduit,
                Description = entity.Description,
                PrixProduit = entity.PrixProduit,
                Id_Categorie = entity.Id_Categorie,
                CritereEco = entity.CritereEco
            };
        }

        public static Produit ToBLL(this ProduitCreateForm entity)
        {
            if (entity is null) return null;
            return new Produit(
                0,
                entity.NomProduit,
                entity.Description,
                entity.PrixProduit,
                entity.CritereEco,
                entity.Id_Categorie
                );
        }
    }
}
