using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Epreuve.Models
{
    public class PanierListItemViewModel
    {
        //[ScaffoldColumn(false)]

        public int Id_Produit { get; set; }
        [DisplayName("Nom du Produit")]
        public string Nom { get; set; }
        [DisplayName("Prix du Produit")]
        [Required(ErrorMessage = "Le prix du produit est obligatoire.")]
        [DataType(DataType.Currency)]
        public decimal Prix { get; set; }
        [DisplayName("Quantité du Produit")]

        public int Quantite { get; set; }
    }
}
