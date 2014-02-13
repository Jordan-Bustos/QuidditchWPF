using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    /// <summary>
    /// Classe representant la reservation d'une place a un match de Quidditch.
    /// </summary>
    public class Reservation : EntityObject
    {

        /// <summary>
        /// La Coupe sur laquel s'effectue la reservation.
        /// </summary>
        private Coupe _coupe;
        /// <summary>
        /// Accesseurs de la Coupe sur laquel s'effectue la reservation.
        /// </summary>
        public Coupe Coupe
        {
            get { return _coupe; }
            set { _coupe = value; }
        }

        /// <summary>
        /// Le match sur lequel s'effectue la reservation.
        /// </summary>
        private Match _match;
        /// <summary>
        /// Accesseurs du match sur lequel s'effectue la reservation.
        /// </summary>
        public Match Match
        {
            get { return _match; }
            set { _match = value; }
        }
        
        /// <summary>
        /// Le nombre de places reservees.
        /// </summary>
        private int _nombrePlacesReservees;
        /// <summary>
        /// Accesseurs du nombre de places reservees.
        /// </summary>
        public int NombrePlacesReservees
        {
            get { return _nombrePlacesReservees; }
            set { _nombrePlacesReservees = value; }
        }

        /// <summary>
        /// Le spectateur qui effectue la reservation.
        /// </summary>
        private Spectateur _spectateur;
        /// <summary>
        /// Accesseurs du spectateur qui effectue la reservation.
        /// </summary>
        public Spectateur Spectateur
        {
            get { return _spectateur; }
            set { _spectateur = value; }
        }

        /// <summary>
        /// Constructeur par defaut.
        /// </summary>
        public Reservation()
            : this(-1, new Coupe(), new Match(), 0, new Spectateur())
        {
        }

        /// <summary>
        /// Constructeur complet.
        /// </summary>
        /// <param name="id">L'id de l'objet.</param>
        /// <param name="coupe">La coupe sur laquel s'effectue la reservation.</param>
        /// <param name="match">Le match sur lequel s'effectue la reservation.</param>
        /// <param name="nombrePlacesReservees">Le nombre de places reservees.</param>
        /// <param name="spectateur">Le spectateur qui effectue la reservation.</param>
        public Reservation(int id, Coupe coupe, Match match, int nombrePlacesReservees, Spectateur spectateur)
            : base(id)
        {
            _coupe = coupe;
            _match = match;
            _nombrePlacesReservees = nombrePlacesReservees;
            _spectateur = spectateur;
        }

        public override string ToString()
        {
            return String.Format("{0} - place(s) : {1}", 
                                 this.Spectateur.ToString().ToUpper(),
                                 this.NombrePlacesReservees
                                 );
        }

    }
}
