using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;
using SubDataAccessLayer;

namespace BusinessLayer
{
    /// <summary>
    /// Classe permettant a l'application de decentraliser et d'executer les demandes de la couche presentation.
    /// </summary>
    public class BusinessManager
    {
        /// <summary>
        /// Permet de reucperer la liste des coupes existantes.
        /// </summary>
        /// <returns>La liste des coupes existantes.</returns>
        static public IEnumerable<String> getCoupesInIEnumeranbleString()
        {
            IEnumerable<String> listeCoupes = from coupe
                                              in SubDalManager.Instance.getCoupes()
                                              select coupe.Nom;
            return listeCoupes;
        }

        /// <summary>
        /// Permet de recuperer la liste des matchs prévus d'une coupe classés par date de début.
        /// </summary>
        /// <param name="coupeARechercher">La coupe sur laquelle on effectue la recherche.</param>
        /// <returns>la liste des matchs prévus d'une coupe classés par date de début.</returns>
        static public IEnumerable<String> getMatchs(String coupeARechercher)
        {
            IEnumerable<String> listeMatchs = from coupe
                                              in SubDalManager.Instance.getCoupes()
                                              from match in coupe.Matchs 
                                              orderby match.Date ascending
                                              where coupe.Nom.Equals(coupeARechercher)
                                              select match.ToString();
            return listeMatchs;
        }

        /// <summary>
        /// Permet de recuperer la liste des Stades d'une coupe pour lesquels au moins un Match est programmé. 
        /// </summary>
        /// <param name="matchARechercher">La coupe sur laquelle on effectue la recherche.</param>
        /// <returns>la liste des Stades d'une coupe pour lesquels au moins un Match est programmé. </returns>
        static public IEnumerable<String> getStades(String coupeARechercher)
        {
            IEnumerable<String> listeStades = from coupe
                                              in SubDalManager.Instance.getCoupes()
                                              from match in coupe.Matchs
                                              where coupe.Nom.Equals(coupeARechercher)
                                              select match.Stade.ToString();
            return listeStades;

        }

        /// <summary>
        /// Permet de recuperer la liste des attrapeurs d'une coupe qui ont joués à domicile.
        /// </summary>
        /// <param name="coupeARechercher">La coupe sur laquelle on effectue la recherche.</param>
        /// <returns>La liste des attrapeurs d'une coupe qui ont joués à domicile.</returns>
        static public IEnumerable<String> getAttrapeursDom(String coupeARechercher)
        {
            IEnumerable<String> listeAtrapeursDom = from coupe
                                                    in SubDalManager.Instance.getCoupes()
                                                    from match in coupe.Matchs
                                                    from joueursDomicile in match.EquipeDomicile.Joueurs
                                                    where coupe.Nom.Equals(coupeARechercher)
                                                    where joueursDomicile.Poste == EntitiesLayer.PosteJoueur.Attrapeur
                                                    select joueursDomicile.ToString();
            return listeAtrapeursDom;
        }

        /// <summary>
        /// Permet de recuperer la liste des coupes.
        /// </summary>
        /// <returns>La liste des coupes.</returns>
        static public List<Coupe> getCoupes()
        {
            IEnumerable<Coupe> listeCoupes = from coupe
                                              in SubDalManager.Instance.getCoupes()
                                              select coupe;
            return new List<Coupe>(listeCoupes);
        }

        /// <summary>
        /// Permet de recuperer la liste des équipes.
        /// </summary>
        /// <returns>La liste des equipes.</returns>
        static public List<Equipe> getEquipes()
        {
            IEnumerable<Equipe> listeEquipes = from equipe
                                              in SubDalManager.Instance.getEquipes()
                                             select equipe;
            return new List<Equipe>(listeEquipes);
        }

        /// <summary>
        /// Permet de recuperer la liste des joueurs.
        /// </summary>
        /// <returns>La liste des joueurs.</returns>
        static public List<Joueur> getJoueurs()
        {
            IEnumerable<Joueur> listeJoueurs = from joueur
                                              in SubDalManager.Instance.getJoueurs()
                                               select joueur;
            return new List<Joueur>(listeJoueurs);
        }

        /// <summary>
        /// Permet de recuperer la liste des matchs.
        /// </summary>
        /// <returns>La liste des matchs.</returns>
        static public List<Match> getMatchs()
        {
            IEnumerable<Match> listeMatchs = from match
                                              in SubDalManager.Instance.getMatchs()
                                              select match;
            return new List<Match>(listeMatchs);
        }

        /// <summary>
        /// Permet de recuperer la liste des stades.
        /// </summary>
        /// <returns>La liste des stades.</returns>
        static public List<Stade> getStades()
        {
            IEnumerable<Stade> listeStades = from stade
                                              in SubDalManager.Instance.getStades()
                                             select stade;
            return new List<Stade>(listeStades);
        }

        /// <summary>
        /// Permet de recuperer la liste des reservations.
        /// </summary>
        /// <returns>La liste des reservations.</returns>
        static public List<Reservation> getReservations()
        {
            IEnumerable<Reservation> listeReservations = from reservation
                                              in SubDalManager.Instance.getReservations()
                                             select reservation;
            return new List<Reservation>(listeReservations);
        }
    }
}
