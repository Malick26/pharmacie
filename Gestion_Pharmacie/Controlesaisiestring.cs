using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Pharmacie
{
    public class Controlesaisiestring
    {
        public string ControlerSaisie(string message,string saisie)
        {

            do
            {
                Console.WriteLine(message);
                saisie = Console.ReadLine();

                if (string.IsNullOrEmpty(saisie))
                {
                    Console.WriteLine("Veuillez saisir une valeur valide.");
                }

            } while (string.IsNullOrEmpty(saisie));

            return saisie;
        }


        public decimal ControlerSaisieDecimal(string message, decimal saisie)
        {
             
            bool saisieValide = false;

            do
            {
                Console.WriteLine(message);
                string saisieString = Console.ReadLine();

                if (decimal.TryParse(saisieString, out saisie))
                {
                    saisieValide = true;
                }
                else
                {
                    Console.WriteLine("Veuillez saisir un nombre décimal valide.");
                }

            } while (!saisieValide);

            return saisie;
        }


        public int ControlerSaisieInt(string message,int saisie)
        {
           
            bool saisieValide = false;

            do
            {
                Console.WriteLine(message);
                string saisieString = Console.ReadLine();

                if (int.TryParse(saisieString, out saisie))
                {
                    saisieValide = true;
                }
                else
                {
                    Console.WriteLine("Veuillez saisir un nombre entier valide.");
                }

            } while (!saisieValide);

            return saisie;
        }

    }
}