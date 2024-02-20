using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Epreuve.Entities
{
    public class Commande
    {

        public int Id_Commande { get; set; }
        public int Quantite { get; set; }
        public int Id_Produit { get; set; }

        public Commande(int id_Commande, int quantite, int id_Produit)
        {
            Id_Commande = id_Commande;
            Quantite = quantite;
            Id_Produit = id_Produit;
        }
    }
}
