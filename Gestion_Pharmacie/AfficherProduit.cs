using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Pharmacie
{
    public class AfficherProduit
    {


    
            public void Afficher(List<Produits> produits)
            {
               

                Console.WriteLine("Liste des produits :");
                Console.WriteLine("---------------------");

             
                    foreach(Produits produit in produits)
                    {
                      Console.WriteLine($"ID : {produit.getId()}");
                      Console.WriteLine($"Nom : {produit.getNom()}");
                      Console.WriteLine($"Description : {produit.getDescription()}");
                      Console.WriteLine($"Prix : {produit.getPrix()}");
                       Console.WriteLine($"Stock : {produit.getStock()}");
                      Console.WriteLine("-------------------------");
            }
      }
            
        
    }
}
