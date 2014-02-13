using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    /// <summary>
    /// Classe qui represente une equipe de Quidditch.
    /// </summary>
    public class Equipe : EntityObject , IComparable<Equipe>
    {
        /// <summary>
        /// La liste des joueurs de l'equipe.
        /// </summary>
        private List<Joueur> _joueurs;
        /// <summary>
        /// Accesseurs de la liste des joueurs de l'equipe.
        /// </summary>
        public List<Joueur> Joueurs
        {
            get { return _joueurs; }
            set { _joueurs = value; }
        }

        /// <summary>
        /// Le nom de l'equipe.
        /// </summary>
        private String _nom;
        /// <summary>
        /// Accesseurs du nom de l'equipe.
        /// </summary>
        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        /// <summary>
        /// Le pays que represente l'equipe.
        /// </summary>
        private String _pays;
        /// <summary>
        /// Accesseurs du pays qui represente l'equipe.
        /// </summary>
        public String Pays
        {
            get { return _pays; }
            set { _pays = value; }
        }

        /// <summary>
        /// Constructeur par defaut.
        /// </summary>
        public Equipe()
            : this(-1, new List<Joueur>(), "<new joueur>", "<pays>")
        {
        }

        /// <summary>
        /// Constructeur complet.
        /// </summary>
        /// <param name="id">L'id de l'objet.</param>
        /// <param name="joueurs">La liste des joueurs de l'equipe.</param>
        /// <param name="nom">Le nom de l'equipe.</param>
        /// <param name="pays">Le pays que reprensete l'equipe.</param>
        public Equipe(int id, List<Joueur> joueurs, String nom, String pays)
            : base(id)
        {
            _joueurs = joueurs;
            _nom = nom;
            _pays = pays;
        }

        /// <summary>
        /// Reimplementation de la methode d'affichage d'une equipe.
        /// </summary>
        /// <returns>L'affichage d'une equipe.</returns>
        public override string ToString()
        {
            return _nom;
        }

        /// <summary>
        /// Permet de comparer deux equipes.
        /// </summary>
        /// <param name="other">L'equipe a comparer.</param>
        /// <returns>0 si =, -1 si < à other, 1 si > à other.</returns>
        public int CompareTo(Equipe other)
        {
            return _nom.CompareTo(other.Nom);
        }

    }
}
