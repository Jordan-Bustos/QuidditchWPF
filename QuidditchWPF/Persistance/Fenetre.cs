using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchWPF.Persistance
{
    /// <summary>
    /// Classe permettant de stocker les proprietes des fenetres de l'application.
    /// </summary>
    [Serializable]
    public class Fenetre 
    {
        /// <summary>
        /// Le nom de la fenetre.
        /// </summary>
        private string _name;
        /// <summary>
        /// Accesseurs du nom de la fenetre.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// La position x de la fenetre dans l'ecran.
        /// </summary>
        private double _posX;
        /// <summary>
        /// Accesseurs de la position x de la fenetre dans l'ecran.
        /// </summary>
        public double PosX
        {
            get { return _posX; }
            set { _posX = value; }
        }

        /// <summary>
        /// La position y de la fenetre dans l'ecran.
        /// </summary>
        private double _posY;
        /// <summary>
        /// Accesseurs de la position y de la fenetre dans l'ecran.
        /// </summary>
        public double PosY
        {
            get { return _posY; }
            set { _posY = value; }
        }

        /// <summary>
        /// La hauteur de la fenetre.
        /// </summary>
        private double _hauteur;
        /// <summary>
        /// Accesseurs de la hauteur de la fenetre.
        /// </summary>
        public double Hauteur
        {
            get { return _hauteur; }
            set { _hauteur = value; }
        }

        /// <summary>
        /// La largeur de la fenetre.
        /// </summary>
        private double _largeur;
        /// <summary>
        /// Accesseurs de la largeur de la fenetre.
        /// </summary>
        public double Largeur
        {
            get { return _largeur; }
            set { _largeur = value; }
        }

        /// <summary>
        /// Constructeur par defaut.
        /// </summary>
        public Fenetre()
            : this("WindowUnnamed",50d,50d,300d,300d)
        {}

        /// <summary>
        /// Constructeur complet.
        /// </summary>
        /// <param name="name">Le nom de la fenetre.</param>
        /// <param name="posX">La position x de la fenetre dans l'ecran.</param>
        /// <param name="posY">La position y de la fenetre dans l'ecran.</param>
        /// <param name="hauteur">La hauteur de la fenetre.</param>
        /// <param name="largeur">La largeur de la fenetre.</param>
        public Fenetre(String name, double posX, double posY, double hauteur, double largeur)
        {
            _name = name;
            _posX = posX;
            _posY = posY;
            _hauteur = hauteur;
            _largeur = largeur;
        }
    }
}
