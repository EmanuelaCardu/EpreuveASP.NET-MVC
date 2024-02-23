using ASP_Epreuve.Models;
using BLL_Epreuve.Entities;
using System.Text.Json;

namespace ASP_Epreuve.Handlers
{
    public class PanierSessionManager : SessionManager
    {
        public PanierSessionManager(IHttpContextAccessor httpContext) : base(httpContext)
        {
        }

        public IEnumerable<Produit> Panier
        {
            get
            {
                if (_session.GetString(nameof(Panier)) is null)
                    Panier = new List<Produit>();
                return JsonSerializer.Deserialize<Produit[]>(_session.GetString(nameof(Panier)));
            }
            private set
            {
                _session.SetString(nameof(Panier), JsonSerializer.Serialize(value));
            }
        }

        public void AddProduit(Produit produit)
        {
            List<Produit> produits = new List<Produit>(Panier);
            produits.Add(produit);
            Panier = produits;
        }

        public IEnumerable<Produit> GetProduit()
        {
            return Panier;
        }


        //public Panier? Panier     //Permet de récupérer les données du panier sauvgardées en session
        //{
        //    //Deserialize : JSON => C#
        //    get { return JsonSerializer.Deserialize<Panier>(_session.GetString(nameof(Panier)) ?? "null"); }
        //}

        //public void CommencePanier(Panier panier)   //Permet de sauvegarder les données du panier dans la session
        //{
        //    if (panier is null) throw new ArgumentNullException(nameof(panier), "Le panier est null");
        //    if (!(_session.GetString(nameof(Panier)) is null)) throw new InvalidOperationException("il y a déjà un panier ");
        //    //Serialize : C# => JSON
        //    _session.SetString(nameof(Panier), JsonSerializer.Serialize(panier));
        //}

        //public void EffacePanier()   //Permet de supprimer les données du panier dans la session
        //{
        //    if (_session.GetString(nameof(Panier)) is null) throw new InvalidOperationException("Le panier è vide.");
        //    _session.Remove(nameof(Panier));
        //}
    }
}
