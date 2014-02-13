using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    /// <summary>
    /// Classe qui permet de representer un object par un id.
    /// </summary>
    public class EntityObject
    {
        /// <summary>
        /// L'id qui identifie un objet.
        /// </summary>
        private int _id;
        /// <summary>
        /// Accesseurs de l'id.
        /// </summary>
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Constructeur par defaut.
        /// </summary>
        public EntityObject() 
        {
        }

        /// <summary>
        /// Constructeur complet.
        /// </summary>
        /// <param name="id">L'id de l'objet.</param>
        public EntityObject(int id)
        {
            _id = id;
        }

        /// <summary>
        /// Reimplementation du protocole d'egalite.
        /// </summary>
        /// <param name="obj">L'objet a comparer.</param>
        /// <returns>Retourne 0 si les deux objets sont identiques, -1 si inferieur, et 1 si superieur.</returns>
        public override bool Equals(object obj)
        {
            EntityObject other = null ;
            try
            {
                other = obj as EntityObject;

            }
            catch (Exception)
            { return false; }

            if (other != null)
                return ID == other.ID;
            else return false;
        }

        /// <summary>
        /// Reimplementation de la methode de hashage.
        /// </summary>
        /// <returns>Un nombre unique identifiant l'objet.</returns>
        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
}
