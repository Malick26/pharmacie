using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Pharmacie
{

    public class AjouterProduit
    {
        Produits produit;



        public Produits Ajouter()
        {
            
            {
                

                do
                {
                    // Déclaration des variables
                    string nom = string.Empty;
                    string description = string.Empty;
                    decimal prix = 0;
                    int stock = 0;

                    Console.WriteLine("Veuillez saisir le nom :");
                    nom = Console.ReadLine();

                    Console.WriteLine("Veuillez saisir la description :");
                    description = Console.ReadLine();

                    Console.WriteLine("Veuillez saisir le prix :");
                    decimal.TryParse(Console.ReadLine(), out prix);

                    Console.WriteLine("Veuillez saisir la quantité :");
                    int.TryParse(Console.ReadLine(), out stock);

                    produit = new Produits(nom, description, prix, stock);

                    // Ajouter le produit à la liste ou effectuer d'autres opérations de gestion des produits

                    Console.WriteLine("Tapez '1' pour ajouter un autre produit, ou ')' pour quitter :");
                } while (Console.ReadLine() == "1");

                return produit;
            }

        }





    }

}
