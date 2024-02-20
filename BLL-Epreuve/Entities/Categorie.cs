using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Epreuve.Entities
{
    public class Categorie
    {

        public int Id_Categorie { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }

        public Categorie(int id_Categorie, string nom, string description)
        {
            Id_Categorie = id_Categorie;
            Nom = nom;
            Description = description;
        }
    }
}
