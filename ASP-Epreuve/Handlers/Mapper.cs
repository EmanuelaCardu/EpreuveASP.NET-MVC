using ASP_Epreuve.Models;
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

        public static PanierListItemViewModel ToPanier(this Produit entity)
        {
            if (entity is null) return null;
            return new PanierListItemViewModel
            {
                Id_Produit = entity.Id_Produit,
                Nom = entity.NomProduit,
               Prix =entity.PrixProduit,
               Quantite = 1
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

        public static ProduitEditForm ToEdit(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitEditForm()
            {
                Id_Produit = entity.Id_Produit,
                NomProduit = entity.NomProduit,
                Description = entity.Description,
                PrixProduit = entity.PrixProduit,
                Id_Categorie = entity.Id_Categorie,
                CritereEco = entity.CritereEco
            };
        }

        public static Produit ToBLL(this ProduitEditForm entity)
        {
            if (entity is null) return null;
            return new Produit(
                entity.Id_Produit,
                entity.NomProduit,
                entity.Description,
                entity.PrixProduit,
                entity.CritereEco,
                entity.Id_Categorie
                );
        }

        public static ProduitDeleteViewModel ToDelete(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitDeleteViewModel()
            {
                Id_Produit = entity.Id_Produit,
                NomProduit = entity.NomProduit,
                Description = entity.Description,
                PrixProduit = entity.PrixProduit,
                Id_Categorie = entity.Id_Categorie,
                CritereEco = entity.CritereEco
            };
        }
    }
}
