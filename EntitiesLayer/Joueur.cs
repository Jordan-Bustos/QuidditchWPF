using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    /// <summary>
    /// Classe qui permet de representer un joueur de Quidditch.
    /// </summary>
    public class Joueur : Personne , IComparable<Joueur>
    {
        /// <summary>
        /// Le nombre de selection du joueur dans une annee.
        /// </summary>
        private int _nbSelection;
        /// <summary>
        /// Accesseurs du nombre de selection du joueur.
        /// </summary>
        public int NbSelection
        {
            get { return _nbSelection; }
            set { _nbSelection = value; }
        }

        /// <summary>
        /// Le poste du joueur.
        /// </summary>
        private PosteJoueur _poste;
        /// <summary>
        /// Accesseurs du poste du joueur.
        /// </summary>
        public PosteJoueur Poste
        {
            get { return _poste; }
            set { _poste = value; }
        }

        /// <summary>
        /// Le score du joueur.
        /// </summary>
        private int _score;
        /// <summary>
        /// Accesseurs du score du joueur.
        /// </summary>
        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        /// <summary>
        /// Constructeur par defaut.
        /// </summary>
        public Joueur()
            : this(-1, DateTime.Now, "<new joueur>", "<new joueur>", 0, PosteJoueur.None, 0)
        {
        }

        /// <summary>
        /// Constructeur complet.
        /// </summary>
        /// <param name="id">L'id de l'objet.</param>
        /// <param name="dateNaissance">La date de naissance du joueur.</param>
        /// <param name="nom">Le nom du joueur.</param>
        /// <param name="prenom">Le prenom du joueur.</param>
        /// <param name="nbSelection">Le nombre de selection du joueur.</param>
        /// <param name="poste">Le poste du joueur.</param>
        /// <param name="score">Le score du joueur.</param>
        public Joueur(int id, DateTime dateNaissance, String nom, String prenom, int nbSelection, PosteJoueur poste, int score)
            : base(id, dateNaissance, nom, prenom)
        {
            _nbSelection = nbSelection;
            _poste = poste;
            _score = score;
        }

        /// <summary>
        /// Reimplementation de la methode d'affichage d'un joueur.
        /// </summary>
        /// <returns>L'affichage d'un joueur.</returns>
        public override string ToString()
        {
            StringBuilder chaine = new StringBuilder();
            chaine.Append(_poste.ToString()).Append(" ").Append(Prenom).Append(" ").Append(Nom);
            return chaine.ToString();
        }

        /// <summary>
        /// Permet de comparer deux joueurs.
        /// </summary>
        /// <param name="other">Le stade a comparer.</param>
        /// <returns>0 si =, -1 si < à other, 1 si > à other.</returns>
        public int CompareTo(Joueur other)
        {
            return _poste.ToString().CompareTo(other.Poste.ToString());
        }

    }
}
