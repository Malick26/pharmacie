using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Pharmacie
{
    public class RechercherProduit
    {
        public void Recherche(List<Produits> produits)
        {
            Console.WriteLine("Donnez l'ID du medicament a rechercher");
            int id = Convert.ToInt32(Console.ReadLine());

            foreach (Produits produit in produits)
            {
               if (id == produit.getId()) 
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
}
