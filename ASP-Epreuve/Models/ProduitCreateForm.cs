using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using BLL_Epreuve.Entities;

namespace ASP_Epreuve.Models
{
    public class ProduitCreateForm
    {
        [ScaffoldColumn (false)]
      
        public int Id_Produit { get; set; }
        [DisplayName("Nom du Produit")]
        [Required(ErrorMessage = "Le nom du produit est obligatoire.")]
        [MaxLength(50, ErrorMessage = "Le nom du produit ne peut dépasser 50 caractères.")]
        [MinLength(1, ErrorMessage = "Le nom du produit doit avoir au minimum 1 caractères.")]
        public string NomProduit { get; set; }
        [DisplayName("Description du Produit")]
        [Required(ErrorMessage = "La description du produit est obligatoire.")]
        [MaxLength(1000, ErrorMessage = "La description du produit ne peut dépasser 1000 caractères.")]
        [MinLength(1, ErrorMessage = "La description du produit doit avoir au minimum 1 caractères.")]
        public string Description { get; set; }

        [DisplayName("Prix du Produit")]
        [Required(ErrorMessage = "Le prix du produit est obligatoire.")]
        [DataType(DataType.Currency)]

        public decimal PrixProduit { get; set; }
        [DisplayName("Critères ECO")]
        [Required(ErrorMessage = "Le critère Eco du produit est obligatoire.")]
        [RegularExpression("^[ABCDE]$", ErrorMessage = "Veuillez choisir parmi les lettres A, B, C, D ou E.")]
       
        public string CritereEco { get; set; }

        [DisplayName("Choisir la categorie du produit")]
        [Required(ErrorMessage = "Lla categorie du produit est obligatoire.")]
        //faire ici une liste des categorie
        public int Id_Categorie { get; set; }

        public List<Categorie> Categories { get; set; }
    }
}
