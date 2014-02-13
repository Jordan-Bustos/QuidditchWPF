using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    /// <summary>
    /// Classe abstraite representant une personne.
    /// </summary>
    public abstract class Personne : EntityObject
    {
        /// <summary>
        /// La date de naissance de la personne.
        /// </summary>
        private DateTime _dateNaissance;
        /// <summary>
        /// Accesseurs de la date de naissance de la personne.
        /// </summary>
        public DateTime DateNaissance
        {
            get { return _dateNaissance; }
            set { _dateNaissance = value; }
        }

        /// <summary>
        /// Le nom de la personne.
        /// </summary>
        private String _nom;
        /// <summary>
        /// Accesseurs du nom de la personne.
        /// </summary>
        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        /// <summary>
        /// Le prenom de la personne.
        /// </summary>
        private String _prenom;
        /// <summary>
        /// Accesseurs du prenom de la personne.
        /// </summary>
        public String Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        /// <summary>
        /// Constructeur par defaut.
        /// </summary>
        public Personne()
            : this(-1, DateTime.Now, "<new personne>", "<new personne>")
        {
        }

        /// <summary>
        /// Constructeur complet.
        /// </summary>
        /// <param name="id">L'id de l'objet.</param>
        /// <param name="dateNaissance">La date de naissance de la personne.</param>
        /// <param name="nom">Le nom de la personne.</param>
        /// <param name="prenom">Le prenom de la personne.</param>
        public Personne(int id, DateTime dateNaissance, String nom, String prenom)
            : base(id)
        {
            _dateNaissance = dateNaissance;
            _nom = nom;
            _prenom = prenom;
        }

    }
}
