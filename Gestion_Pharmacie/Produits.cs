using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Pharmacie
{
    public class Produits
    {
        private int NextId=1;
        public static int Id { get; set; }
        public static string Nom { get; set; }
        public static string Description { get; set; }
        public static decimal Prix { get; set; }
        public static int Stock { get; set; }

        public string getNom()
        {
            return Nom;
        }

        public string getPrenom()
        {
            return Nom;
        }
        public string getDescription()
        {
            return Nom;
        }

        public int getId()
        {
            return Id;
        }

        public decimal getPrix()
        {
            return Prix;
        }

        public int getStock()
        {
            return Stock;
        }
        public Produits(string nom, string description, decimal prix, int stock)
        {
            Id = IncrementeID();
            Nom = nom;
            Description = description;
            Prix = prix;
            Stock = stock;
        }

        public int IncrementeID()
        {
            return NextId++;
        }

    }
}
