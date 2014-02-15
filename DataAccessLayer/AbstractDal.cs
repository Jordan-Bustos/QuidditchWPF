using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;

namespace DataAccessLayer
{
    /// <summary>
    /// Le bridge.
    /// </summary>
    public interface AbstractDal
    {
        /// <summary>
        /// Permet de recuperer les coupes.
        /// </summary>
        /// <returns>Les coupes.</returns>
        List<Coupe> getCoupes();

        /// <summary>
        /// Permet de recuperer les equipes.
        /// </summary>
        /// <returns>Les equipes.</returns>
        List<Equipe> getEquipes();

        /// <summary>
        /// Permet de recuperer les joueurs.
        /// </summary>
        /// <returns>Les joueurs.</returns>
        List<Joueur> getJoueurs();

        /// <summary>
        /// Permet de recuperer les matchs.
        /// </summary>
        /// <returns>Les matchs.</returns>
        List<Match> getMatchs();

        /// <summary>
        /// Permet de recuperer les stades.
        /// </summary>
        /// <returns>Les stades.</returns>
        List<Stade> getStades();

        /// <summary>
        /// Permet de recuperer les reservation.
        /// </summary>
        /// <returns>Les reservations.</returns>
        List<Reservation> getReservations();
    }
}
