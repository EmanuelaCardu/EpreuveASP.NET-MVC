using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_Epreuve.Models
{
    public class ProduitDeleteViewModel
    {
        [ScaffoldColumn(false)]

        public int Id_Produit { get; set; }
        [DisplayName("Nom du Produit")]

        public string NomProduit { get; set; }
        [DisplayName("Description")]

        public string Description { get; set; }
        [DisplayName("Prix du produit")]

        public decimal PrixProduit { get; set; }
        [DisplayName("Criteres ECO")]

        public string CritereEco { get; set; }
        [DisplayName("Categorie")]

        public int Id_Categorie { get; set; }
    }
}
