using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Epreuve.Entities
{
    public class Media
    {

        public int Id_Media { get; set; }
        public string Url { get; set; }
        public int Id_Produit { get; set; }

        public Media(int id_Media, string url, int id_Produit)
        {
            Id_Media = id_Media;
            Url = url;
            Id_Produit = id_Produit;
        }
    }
}
