using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Pharmacie
{
    public class AcheterProduit
    {
        public decimal acheter(List<Produits> produits)
        {
            decimal achat = 0;
            List<Produits> acheterlist = new();
            foreach (Produits produit in produits)
            {
                Console.WriteLine("Veuillez saisir l'ID du produit a acheter");
                int id = Convert.ToInt32(Console.ReadLine());
                if (id == produit.getId())
                {
                    Console.WriteLine("Vous en voulez combien");
                    int quantite = Convert.ToInt32(Console.ReadLine());
                    if (Stock.verifier_stock(produits, quantite)) 
                    {
                        acheterlist.Add(produit);
                    }
                    else
                    {
                        Console.WriteLine("Quantite Stock Insuffisante");
                    }
                }
            }
            foreach (Produits achater in acheterlist)
            {
                achat = achat + achater.getPrix();
            }
            return achat;
        }

       
    }
}
