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
    }
}
