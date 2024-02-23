using System.ComponentModel;

namespace ASP_Epreuve.Models
{
    public class CategorieListItemViewModel
    {
        [DisplayName("Code du produit")]
        public int Id_Categirie { get; set; }

        [DisplayName("Categorie")]
        public string Nom {  get; set; }

        [DisplayName("Description")]

        public string Description { get; set; }
    }
}
