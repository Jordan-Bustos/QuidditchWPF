using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;

namespace DataAccessLayer
{
    /// <summary>
    /// L'abstraction du pattern Bridge.
    /// </summary>
    public class DalManager
    {
        /// <summary>
        /// Le Bridge.
        /// </summary>
        private AbstractDal _abstractDal;
        /// <summary>
        /// Accesseurs du Bridge.
        /// </summary>
        public AbstractDal AbstractDal
        {
            get { return _abstractDal; }
            set { _abstractDal = value; }
        }

        /// <summary>
        /// L'instance unique du DalManager.
        /// </summary>
        private static volatile DalManager _instance;

        /// <summary>
        /// L'objet servant au lock.
        /// </summary>
        private static readonly object padlock = new Object();

        /// <summary>
        /// Accesseur de l'instance du DalManager.
        /// </summary>
        public static DalManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DalManager();
                        }
                    }
                }
                return _instance;
            }
        }

        /// <summary>
        /// Constructeur privee. Instancie une base de donnees sql serveur.
        /// </summary>
        private DalManager()
        {
            _abstractDal = new SqlDataBase();
        }

        /// <summary>
        /// Permet de recuperer les coupes.
        /// </summary>
        /// <returns>Les coupes.</returns>
        public List<Coupe> getCoupes()
        {
            return _abstractDal.getCoupes();
        }

        /// <summary>
        /// Permet de recuperer les equipes.
        /// </summary>
        /// <returns>Les equipes.</returns>
        public List<Equipe> getEquipes()
        {
            return _abstractDal.getEquipes();
        }

        /// <summary>
        /// Permet de recuperer les joueurs.
        /// </summary>
        /// <returns>Les joueurs.</returns>
        public List<Joueur> getJoueurs()
        {
            return _abstractDal.getJoueurs();
        }

        /// <summary>
        /// Permet de recuperer les matchs.
        /// </summary>
        /// <returns>Les matchs.</returns>
        public List<Match> getMatchs()
        {
            return _abstractDal.getMatchs();
        }

        /// <summary>
        /// Permet de recuperer les stades.
        /// </summary>
        /// <returns>Les stades.</returns>
        public List<Stade> getStades()
        {
            return _abstractDal.getStades();
        }

        /// <summary>
        /// Permet de recuperer les reservation.
        /// </summary>
        /// <returns>Les reservations.</returns>
        public List<Reservation> getReservations()
        {
            return _abstractDal.getReservations();
        }
    }
}
