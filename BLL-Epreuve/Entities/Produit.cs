﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Epreuve.Entities
{
    public class Produit
    {

        public int Id_Produit { get; set; }
        public string NomProduit { get; set; }
        public string Description { get; set; }
        public decimal PrixProduit { get; set; }
        public string CritereEco { get; set; }
        public string Categorie { get; set; }

        public Produit(int id_Produit, string nomProduit, string description, decimal prixProduit, string critereEco, string categorie)
        {
            Id_Produit = id_Produit;
            NomProduit = nomProduit;
            Description = description;
            PrixProduit = prixProduit;
            CritereEco = critereEco;
            Categorie = categorie;
        }
    }
}
