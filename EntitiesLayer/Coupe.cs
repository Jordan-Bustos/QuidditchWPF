using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    /// <summary>
    /// Classe permettant de representer une coupe de Quidditch.
    /// </summary>
    public class Coupe : EntityObject , IComparable<Coupe>
    {
        /// <summary>
        /// L'annee de la coupe.
        /// </summary>
        private int _year;
        /// <summary>
        /// Accesseurs de l'annee de la coupe.
        /// </summary>
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        /// <summary>
        /// Le nom de la coupe.
        /// </summary>
        private String _nom;
        /// <summary>
        /// Accesseurs du nom de la coupe.
        /// </summary>
        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }


        /// <summary>
        /// La liste des matchs de la coupe.
        /// </summary>
        private List<Match> _matchs;
        /// <summary>
        /// Accesseurs de la liste des matchs de la coupe.
        /// </summary>
        public List<Match> Matchs
        {
            get { return _matchs; }
            set { _matchs = value; }
        }

        /// <summary>
        /// La liste des equipes participantes a la coupe.
        /// </summary>
        private List<Equipe> _equipes;
        /// <summary>
        /// Accesseurs de la liste des equipes participantes a la coupe.
        /// </summary>
        public List<Equipe> Equipes
        {
            get { return _equipes; }
            set { _equipes = value; }
        }

        /// <summary>
        /// Constructeur par defaut.
        /// </summary>
        public Coupe()
            : this(-1, "<new coupe>", DateTime.Today.Year, new List<Match>(), new List<Equipe>())
        {
        }

        /// /// <summary>
        /// Constructeur d'une coupe.
        /// </summary>
        /// <param name="id">L'id de l'objet/</param>
        /// <param name="nom">Le nom de la coupe.</param>
        /// <param name="year">L'annee de la coupe.</param>
        /// <param name="matchs">La liste des matchs de la coupe</param>
        /// <param name="equipes">La liste des equipes participantes a la coupe.</param>
        public Coupe(int id, String nom, int year, List<Match> matchs, List<Equipe> equipes)
            : base(id)
        {
            _year = year;
            _nom = nom;
            _matchs = matchs;
            _equipes = equipes;
        }

        /// <summary>
        /// Redefinition du tostring.
        /// </summary>
        /// <returns>L'affichage d'une coupe.</returns>
        public override string ToString()
        {
            StringBuilder coupe = new StringBuilder();
            coupe.Append(Year).Append(" - ").Append(Nom);
            return coupe.ToString();
        }

        /// <summary>
        /// Permet de comparer deux coupes.
        /// </summary>
        /// <param name="other">La coupe a comparer.</param>
        /// <returns>0 si =, -1 si < à other, 1 si > à other.</returns>
        public int CompareTo(Coupe other)
        {
            return _year.CompareTo(other._year);
        }

    }
}
