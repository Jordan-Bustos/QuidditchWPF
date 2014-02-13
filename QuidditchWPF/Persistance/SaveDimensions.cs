using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;
using System.IO;

namespace QuidditchWPF.Persistance
{
    /// <summary>
    /// Classe qui permet de gerer les positions et dimensions des fenetres de l'application.
    /// </summary>
    [Serializable]
    public class SaveDimensions
    {
        /// <summary>
        /// La liste des fenetres de l'application.
        /// </summary>
        private List<Fenetre> _fenetres;
        /// <summary>
        /// Accesseurs des fenetres de l'application.
        /// </summary>
        public List<Fenetre> Fenetres
        {
            get { return _fenetres; }
            set { _fenetres = value; }
        }

        /// <summary>
        /// L'instance unique de la classe de savegarde des dimensions.
        /// </summary>
        private static SaveDimensions instance;

        /// <summary>
        /// Le constructeur prive.
        /// </summary>
        private SaveDimensions()
        {
            Fenetres = new List<Fenetre>();
        }

        /// <summary>
        /// Permet d'obtenir l'instance unique de la classe de sauvegarde des dimensions.
        /// </summary>
        /// <returns>L'instance unique de la classe de sauvegarde des dimensions.</returns>
        public static SaveDimensions GetInstance()
        {
            if (instance == null)
                instance = new SaveDimensions();
            return instance;
        }

        /// <summary>
        /// Permet de sauvegarder les dimensions et position d'une fenetre dans la liste des fenetres de l'application.
        /// </summary>
        /// <param name="window">La fenetre a sauvegarder.</param>
        public void saveDimensionsFenetre(Window window)
        {
            if (window != null)
            {
                if (SaveDimensions.GetInstance().getFenetreByName(window.Title) != null)
                {
                    Fenetre currentFenetre = getFenetreByName(window.Title);

                    currentFenetre.PosX = window.Left;
                    currentFenetre.PosY = window.Top;
                    currentFenetre.Hauteur = window.Height;
                    currentFenetre.Largeur = window.Width;
                }
                else
                {
                   Fenetres.Add(new Fenetre(window.Title, window.Left, window.Top, window.Height, window.Width));
                }
            }
        }

        /// <summary>
        /// Permet de charger les dimensions et position d'une fenetre dans la liste des fenetres de l'application.
        /// </summary>
        /// <param name="window">La fenetre a sauvegarder.</param>
        public void loadDimensionsFenetre(Window window)
        {
            if (SaveDimensions.GetInstance().getFenetreByName(window.Title) != null)
            {
                Fenetre currentFenetre = getFenetreByName(window.Title);

                window.Left = currentFenetre.PosX;
                window.Top = currentFenetre.PosY;
                window.Height = currentFenetre.Hauteur;
                window.Width = currentFenetre.Largeur;
            }
        }

        /// <summary>
        /// Permet de serializer l'ensemble des fenetres.
        /// </summary>
        public void SaveFenetresProperties()
        {
            string path = "../../Save/Fenetres/SerializationFenetre.xml";
            XmlSerializer writer = new XmlSerializer(typeof(SaveDimensions));
            StreamWriter file = new StreamWriter(path);
            writer.Serialize(file, this);
            file.Close();
        }

        /// <summary>
        /// Permet de deserializer l'ensemble des fenetres.
        /// </summary>
        public void LoadFenetresProperties()
        {
            string path = "../../Save/Fenetres/SerializationFenetre.xml";
            if (File.Exists(path))
            {
                XmlSerializer reader = new XmlSerializer(typeof(SaveDimensions));
                StreamReader file = new StreamReader(path);
                SaveDimensions tmp = (SaveDimensions)reader.Deserialize(file);

                GetInstance().Fenetres = tmp.Fenetres;

                file.Close();
            }
        }

        /// <summary>
        /// Permet de rechercher une fenetre dans la liste des fenetres de l'application par son nom.
        /// </summary>
        /// <param name="name">Le nom de la fenetre a rechercher.</param>
        /// <returns>La fenetre a rechercher.</returns>
        public Fenetre getFenetreByName(String name)
        {
            foreach (Fenetre fenetre in Fenetres)
            {
                if (fenetre.Name.Equals(name))
                {
                    return fenetre;
                }
            }
            return null;
        }
    }
}
