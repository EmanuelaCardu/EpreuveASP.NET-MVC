using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Epreuve.Entities
{
    public class Media
    {
        public int Id_Media { get; set; }
        public string Url { get; set; }
        public int Id_Produit { get; set; }
    }
}
