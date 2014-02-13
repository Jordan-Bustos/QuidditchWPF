using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLayer;

namespace QuidditchConsole
{
    /// <summary>
    /// Main de notre application console.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Le main du programme.
        /// </summary>
        /// <param name="args">Les arguments.</param>
        static void Main(string[] args)
        {
            Program program = new Program();
            program.menu();
        }

        /// <summary>
        /// Permet de proposer un menu a l'utilisateur donnant le choix des methodes de la couche BusinessLayer.
        /// </summary>
        private void menu()
        {
            String reponse;
            String coupe;

            Console.WriteLine(getStringNomAppli());
            Console.WriteLine(getStringCommandes());

            reponse = Console.ReadLine();
            while (!reponse.Equals("q"))
            {
                if (reponse.Equals("Coupes"))
                {
                    foreach (String laCoupe in BusinessManager.getCoupesInIEnumeranbleString())
                        Console.WriteLine(laCoupe);
                }

                else if (reponse.StartsWith("Matchs(") && reponse.EndsWith(")") && reponse.Length > 2)
                {
                    coupe = extractCoupe(reponse);
                    foreach (String match in BusinessManager.getMatchs(coupe))
                        Console.WriteLine(match);
                }

                else if (reponse.StartsWith("Stades(") && reponse.EndsWith(")") && reponse.Length > 2)
                {
                    coupe = extractCoupe(reponse);
                    foreach (String stade in BusinessManager.getStades(coupe))
                        Console.WriteLine(stade);
                }

                else if (reponse.StartsWith("Attrapeurs(") && reponse.EndsWith(")") && reponse.Length > 2)
                {
                    coupe = extractCoupe(reponse);
                    foreach (String attrapeur in BusinessManager.getAttrapeursDom(coupe))
                        Console.WriteLine(attrapeur);
                }

                else if (reponse.Equals("h"))
                {
                    Console.WriteLine(getStringCommandes());
                }

                else
                {
                    Console.WriteLine("COMMANDE INCORRECTE");
                }


                Console.WriteLine("\n\n");
                reponse = Console.ReadLine();
            }
        }

        /// <summary>
        /// Permet de recuperer la chaine de caracteres des commandes.
        /// </summary>
        /// <returns>La chaine de caractere des commandes.</returns>
        private String getStringCommandes()
        {
            return "Commandes :\n\n"
                            + "--> 'q' pour quitter\n"
                            + "--> 'h' pour afficher les commandes\n"
                            + "--> 'Coupes' pour afficher l'ensemble des COUPES existantes\n"
                            + "--> 'Matchs(nomCoupe)' pour afficher les MATCH prévus classés par date de début\n"
                            + "--> 'Stades(nomCoupe)' pour afficher les STADE pour lesquels au moins un Match est programmé\n"
                            + "--> 'Attrapeurs(nomCoupe)' pour afficher les ATTRAPEURS qui ont joués à domicile\n";
        }

        /// <summary>
        /// Permet de recuperer la chaine de caracteres du nom de l'appli.
        /// </summary>
        /// <returns>La chaine de caracteres du nom de l'appli.</returns>
        private String getStringNomAppli()
        {
            return "-------------------- Quidditch Application --------------------\n"
                 + "---------------------------------------------------------------\n";
        }

        /// <summary>
        /// Permet d'extraire la coupe d'une commande.
        /// </summary>
        /// <param name="commande">La commande.</param>
        /// <returns>La coupe extraite d'une commande.</returns>
        private String extractCoupe(String commande)
        {
            int indexOfParentheseOne = commande.IndexOf("(");
            String tmp = commande.Substring(indexOfParentheseOne+1);
            int indexOfParentheseTwo = tmp.LastIndexOf(")");
            return tmp.Substring(0, indexOfParentheseTwo);
        }
    }
}
