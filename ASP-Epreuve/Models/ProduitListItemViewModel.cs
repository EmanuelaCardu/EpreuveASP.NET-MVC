using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Epreuve.Models
{
    public class ProduitListItemViewModel
    {
        [ScaffoldColumn(false)]

        public int Id_Produit { get; set; }
        [DisplayName("Nom du Produit")]


        public string NomProduit { get; set; }
        [DisplayName("Description du Produit")]

        public string Description { get; set; }
    }
}
