using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Pharmacie
{
    public class Stock
    {
        public static bool verifier_stock(List<Produits> produits , int quantite)

        {
            bool valeur=false;
            foreach(Produits prod in produits)
            {
                if (prod.getStock() >= quantite)
                {
                   valeur = true;
                }
                else
                    valeur = valeur;
            }
        return valeur;
            
        }
    }
}
