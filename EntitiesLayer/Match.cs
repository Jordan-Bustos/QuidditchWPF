using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    /// <summary>
    /// Classe qui premet de representer un match de Quidditch.
    /// </summary>
    public class Match : EntityObject , IComparable<Match>
    {
        /// <summary>
        /// La coupe courrue du match.
        /// </summary>
        private int _CoupeID;
        /// <summary>
        /// Accesseurs de la coupe courrue du match.
        /// </summary>
        public int CoupeID
        {
            get { return _CoupeID; }
            set { _CoupeID = value; }
        }

        /// <summary>
        /// La date du match.
        /// </summary>
        private DateTime _date;
        /// <summary>
        /// Accesseurs de la date du match.
        /// </summary>
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        /// <summary>
        /// L'equipe a domicile.
        /// </summary>
        private Equipe _equipeDomicile;
        /// <summary>
        /// Accesseurs de l'equipe a domicile.
        /// </summary>
        public Equipe EquipeDomicile
        {
            get { return _equipeDomicile; }
            set { _equipeDomicile = value; }
        }

        /// <summary>
        /// L'equipe visiteur.
        /// </summary>
        private Equipe _equipeVisiteur;
        /// <summary>
        /// Accesseurs de l'equipe visiteur.
        /// </summary>
        public Equipe EquipeVisiteur
        {
            get { return _equipeVisiteur; }
            set { _equipeVisiteur = value; }
        }

        /// <summary>
        /// Le prix du match.
        /// </summary>
        private double _prix;
        /// <summary>
        /// Accesseurs du prix du match.
        /// </summary>
        public double Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        /// <summary>
        /// Le score de l'equipe domicile.
        /// </summary>
        private int _socreEquipeDomicile;
        /// <summary>
        /// Accesseurs du score de l'equipe domicile.
        /// </summary>
        public int SocreEquipeDomicile
        {
            get { return _socreEquipeDomicile; }
            set { _socreEquipeDomicile = value; }
        }

        /// <summary>
        /// Le score de l'equipe visiteur.
        /// </summary>
        private int _scoreEquipeVisiteur;
        /// <summary>
        /// Accesseurs du score de l'equipe visiteur.
        /// </summary>
        public int ScoreEquipeVisiteur
        {
            get { return _scoreEquipeVisiteur; }
            set { _scoreEquipeVisiteur = value; }
        }

        /// <summary>
        /// Le stade ou s'effectue le match.
        /// </summary>
        private Stade _stade;
        /// <summary>
        /// Accesseurs du stade ou s'effectue le match.
        /// </summary>
        public Stade Stade
        {
            get { return _stade; }
            set { _stade = value; }
        }

        /// <summary>
        /// Constructeur par defaut.
        /// </summary>
        public Match()
            : this(-1, -1, DateTime.Now, new Equipe(), new Equipe(), 0d, 0, 0, new Stade())
        {
        }

        /// <summary>
        /// Constructeur complet.
        /// </summary>
        /// <param name="id">L'id de l'objet/</param>
        /// <param name="coupeID">La coupe courrue du match.</param>
        /// <param name="date">La date du match.</param>
        /// <param name="equipeDomicile">L'equipe a domicile.</param>
        /// <param name="equipeVisiteur">L'equipe visiteur.</param>
        /// <param name="prix">Le prix du match.</param>
        /// <param name="scoreEquipeDomicile">Le socre de l'equipe domicile.</param>
        /// <param name="scoreEquipeVisiteur">le score de l'equipe visiteur.</param>
        /// <param name="stade">Le stade ou s'effectue le match.</param>
        public Match(int id, int coupeID, DateTime date, Equipe equipeDomicile, Equipe equipeVisiteur, double prix, int scoreEquipeDomicile, int scoreEquipeVisiteur, Stade stade)
            : base(id)
        {
            _CoupeID = coupeID;
            _date = date;
            _equipeDomicile = equipeDomicile;
            _equipeVisiteur = equipeVisiteur;
            _prix = prix;
            _socreEquipeDomicile = scoreEquipeDomicile;
            _scoreEquipeVisiteur = scoreEquipeVisiteur;
            _stade = stade;
        }

        /// <summary>
        /// Methode d'affichage d'un match.
        /// </summary>
        /// <returns>L'affichage d'un match.</returns>
        public override string ToString()
        {
            StringBuilder chaine = new StringBuilder();
            chaine.Append(_equipeDomicile.ToString()).Append(" VS ").Append(_equipeVisiteur.ToString());
            return chaine.ToString();
        }

        /// <summary>
        /// Permet de comparer deux matchs.
        /// </summary>
        /// <param name="other">Le stade a comparer.</param>
        /// <returns>0 si =, -1 si < à other, 1 si > à other.</returns>
        public int CompareTo(Match other)
        {
            return _date.CompareTo(other.Date);
        }
    }
}
