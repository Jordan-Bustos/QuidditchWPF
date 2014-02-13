using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    /// <summary>
    /// Classe qui represente un spectateur d'un match de Quidditch.
    /// </summary>
    public class Spectateur : Personne
    {
        /// <summary>
        /// L'adresse du spectateur.
        /// </summary>
        private String _adresse;
        /// <summary>
        /// Accesseurs de l'adresse du spectateur.
        /// </summary>
        public String Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        /// <summary>
        /// L'adresse email du spectateur.
        /// </summary>
        private String _email;
        /// <summary>
        /// Accesseurs de l'adresse l'email du spectateur.
        /// </summary>
        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>
        /// Constructeur par defaut.
        /// </summary>
        public Spectateur()
            : this(-1, DateTime.Now, "<new spectateur>", "<new spectateur>", "<adresse>", "<mon.adresse@exemple.com>")
        {
        }

        /// <summary>
        /// Constructeur complet.
        /// </summary>
        /// <param name="id">L'id de l'objet.</param>
        /// <param name="dateNaissance">La date de naissance du spectateur.</param>
        /// <param name="nom">Le nom du spectateur.</param>
        /// <param name="prenom">Le prenom du spectateur.</param>
        /// <param name="adresse">L'adresse du spectateur.</param>
        /// <param name="email">l'adresse email du spectateur.</param>
        public Spectateur(int id, DateTime dateNaissance, String nom, String prenom, String adresse, String email)
            : base(id, dateNaissance, nom, prenom)
        {
            _adresse = adresse;
            _email = email;
        }

        /// <summary>
        /// Reimplementation du toString.
        /// </summary>
        /// <returns>l'affichage du spectateur.</returns>
        public override string ToString()
        {
            return Nom.ToString();
        }

    }
}
