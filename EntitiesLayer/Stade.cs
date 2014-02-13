using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    /// <summary>
    /// Classe qui permet de representer un stade de Quidditch.
    /// </summary>
    public class Stade : EntityObject , IComparable<Stade>
    {
        /// <summary>
        /// L'adresse du stade.
        /// </summary>
        private String _adresse;
        /// <summary>
        /// Accesseurs de l'adresse du stade.
        /// </summary>
        public String Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        /// <summary>
        /// Le nom du stade.
        /// </summary>
        private String _nom;
        /// <summary>
        /// Accesseurs du nom du stade.
        /// </summary>
        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        /// <summary>
        /// La capacite du stade (nombre de places).
        /// </summary>
        private int _nombrePlaces;
        /// <summary>
        /// Accesseurs de la capacite du stade.
        /// </summary>
        public int NombrePlaces
        {
            get { return _nombrePlaces; }
            set { _nombrePlaces = value; }
        }

        /// <summary>
        /// Le pourcentage de commission du stade.
        /// </summary>
        private double _pourcentageCommission;
        /// <summary>
        /// Accesseurs du pourcentage de commission du stade.
        /// </summary>
        public double PourcentageCommission
        {
            get { return _pourcentageCommission; }
            set { _pourcentageCommission = value; }
        }

        /// <summary>
        /// Constructeur par defaut.
        /// </summary>
        public Stade()
            : this(-1, "<adresse>", "<new stade>", 0, 0d)
        {
        }

        /// <summary>
        /// Constructeur complet.
        /// </summary>
        /// <param name="id">L'id de l'objet.</param>
        /// <param name="adresse">L'adresse du stade.</param>
        /// <param name="nom">Le nom du stade/</param>
        /// <param name="nombrePlaces">La capacite du stade (nombre de places).</param>
        /// <param name="pourcentageCommission">Le pourcentage de commission du stade.</param>
        public Stade(int id, String adresse, String nom, int nombrePlaces, double pourcentageCommission)
            : base(id)
        {
            _adresse = adresse;
            _nom = nom;
            _nombrePlaces = nombrePlaces;
            _pourcentageCommission = pourcentageCommission;
        }

        /// <summary>
        /// Reimplementation de la methode d'affichage d'une stade.
        /// </summary>
        /// <returns>L'affichage d'un stade.</returns>
        public override string ToString()
        {
            return _nom;
        }

        /// <summary>
        /// Permet de comparer deux stades.
        /// </summary>
        /// <param name="other">Le stade a comparer.</param>
        /// <returns>0 si =, -1 si < à other, 1 si > à other.</returns>
        public int CompareTo(Stade other)
        {
            return _nom.CompareTo(other.Nom);
        }

    }
}
