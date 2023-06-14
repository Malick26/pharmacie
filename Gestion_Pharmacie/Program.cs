using System;
using System.Collections.Generic;
using System.ComponentModel;
using static Gestion_Pharmacie.AfficherProduit;

namespace Gestion_Pharmacie
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produits> listeproduit = new List<Produits>();
            AjouterProduit ajout = new();
            AfficherProduit affiche = new();
            RechercherProduit rechercher = new();
            AcheterProduit achat = new();
            
            // Ajouter un produit


            // Afficher les produits
            
            
            
      

            bool quitter = false;

            while (!quitter)
            {
                Console.Clear();
                Console.WriteLine("----- Menu -----");
                Console.WriteLine("1. Ajouter un medicament");
                Console.WriteLine("2. Afficher les medicaments");
                Console.WriteLine("3. Rechercher medicament");
                Console.WriteLine("4. Achat");
                Console.WriteLine("5. Quitter");
                Console.WriteLine("-----------------");
                Console.Write("Veuillez choisir une option : ");

                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        var produit = ajout.Ajouter();
                        listeproduit.Add(produit);
                        break;
                    case "2":
                        affiche.Afficher(listeproduit);
                        break;
                    case "3":
                        rechercher.Recherche(listeproduit);
                        break;
                    case "5":
                       Console.WriteLine("Achat total est de :" , achat.acheter(listeproduit));
                        break;
                    default:
                        Console.WriteLine("Option invalide. Veuillez réessayer.");
                        break;
                }

                Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                Console.ReadKey();
            }
        } }
}
