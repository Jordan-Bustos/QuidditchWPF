using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;

namespace SubDataAccessLayer
{
    /// <summary>
    /// Classe qui manage la couche d'acces au donnees en la bouchonant (subtagant).
    /// </summary>
    public class DalManager
    {
        /// <summary>
        /// La liste des joueurs.
        /// </summary>
        private List<Joueur> _joueurs;
        /// <summary>
        /// Accesseurs de la liste des joueurs.
        /// </summary>
        public List<Joueur> Joueurs
        {
            get { return _joueurs; }
            set { _joueurs = value; }
        }

        /// <summary>
        /// La liste des equipes
        /// </summary>
        private List<Equipe> _equipes;
        /// <summary>
        /// Accesseurs de la liste des equipes.
        /// </summary>
        public List<Equipe> Equipes
        {
            get { return _equipes; }
            set { _equipes = value; }
        }

        /// <summary>
        /// La liste des stades.
        /// </summary>
        private List<Stade> _stades;
        /// <summary>
        /// Accesseurs de la liste des stades.
        /// </summary>
        public List<Stade> Stades
        {
            get { return _stades; }
            set { _stades = value; }
        }

        /// <summary>
        /// La liste des matchs.
        /// </summary>
        private List<Match> _matchs;
        /// <summary>
        /// Accesseurs de la liste des matchs.
        /// </summary>
        public List<Match> Matchs
        {
            get { return _matchs; }
            set { _matchs = value; }
        }

        /// <summary>
        /// La liste des coupes.
        /// </summary>
        private List<Coupe> _coupes;
        /// <summary>
        /// Accesseur de la liste des coupes.
        /// </summary>
        public List<Coupe> Coupes
        {
            get { return _coupes; }
            set { _coupes = value; }
        }

        /// <summary>
        /// La liste des reservations.
        /// </summary>
        private List<Reservation> _reservations;
        /// <summary>
        /// Accesseurs des reservatations.
        /// </summary>
        public List<Reservation> Reservations
        {
            get { return _reservations; }
            set { _reservations = value; }
        }

        /// <summary>
        /// L'instance unique du manager.
        /// </summary>
        private static volatile DalManager _instance;
        private static readonly object padlock = new object();

        /// <summary>
        /// Permet de retourner l'instance unique du manager.
        /// </summary>
        /// <returns>L'instance unique du manager.</returns>
        public static DalManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DalManager();
                        }
                    }
                }
                return _instance;
            }
        }

        /// <summary>
        /// Constructeur privee.
        /// </summary>
        private DalManager()
        {
            _coupes = new List<Coupe>();
            _equipes = new List<Equipe>();
            _joueurs = new List<Joueur>();
            _matchs = new List<Match>();
            _stades = new List<Stade>();
            _reservations = new List<Reservation>();
            initialiserDonnees();
        }

        /// <summary>
        /// Lance les methodes permettant d'initialiser les donnees du Quidditch.
        /// </summary>
        private void initialiserDonnees()
        {
            List<Joueur> joueursGryffondor = new List<Joueur>();
            joueursGryffondor.Add(new Joueur(1, new DateTime(1991, 06, 18), "Jonhson", "Angellina", 5, PosteJoueur.Poursuiveur, 0));
            joueursGryffondor.Add(new Joueur(2, new DateTime(1990, 01, 01), "Spinnet", "Alicia", 2, PosteJoueur.Poursuiveur, 0));
            joueursGryffondor.Add(new Joueur(3, new DateTime(1992, 02, 22), "Bell", "Kattie", 1, PosteJoueur.Poursuiveur, 0));
            joueursGryffondor.Add(new Joueur(4, new DateTime(1993, 02, 17), "Weasley", "Fred", 6, PosteJoueur.Batteur, 0));
            joueursGryffondor.Add(new Joueur(5, new DateTime(1992, 04, 05), "Weasley", "George", 4, PosteJoueur.Batteur, 0));
            joueursGryffondor.Add(new Joueur(6, new DateTime(1994, 05, 04), "Dubois", "Olivier", 5, PosteJoueur.Gardien, 0));
            joueursGryffondor.Add(new Joueur(7, new DateTime(1992, 06, 11), "Potter", "Harry", 99, PosteJoueur.Attrapeur, 0));
            _joueurs.AddRange(joueursGryffondor);
            _equipes.Add(new Equipe(8,joueursGryffondor,"Gryffondor","France"));

            List<Joueur> joueursSperpentard = new List<Joueur>();
            joueursSperpentard.Add(new Joueur(9, new DateTime(1991, 01, 07), "SonNom", "Montague", 4, PosteJoueur.Poursuiveur, 0));
            joueursSperpentard.Add(new Joueur(10, new DateTime(1992, 06, 18), "Pucey", "Adrian", 2, PosteJoueur.Poursuiveur, 0));
            joueursSperpentard.Add(new Joueur(11, new DateTime(1990, 07, 19), "Warinton", "SonPrenom", 3, PosteJoueur.Poursuiveur, 0));
            joueursSperpentard.Add(new Joueur(12, new DateTime(1992, 08, 25), "Bole", "Charlie", 9, PosteJoueur.Batteur, 0));
            joueursSperpentard.Add(new Joueur(13, new DateTime(1988, 06, 01), "Derick", "James", 12, PosteJoueur.Batteur, 0));
            joueursSperpentard.Add(new Joueur(14, new DateTime(1992, 09, 10), "Flint", "Marcus", 3, PosteJoueur.Gardien, 0));
            joueursSperpentard.Add(new Joueur(15, new DateTime(1994, 06, 11), "Drago", "Malefoy", 99, PosteJoueur.Attrapeur, 0));
            _joueurs.AddRange(joueursSperpentard);
            _equipes.Add(new Equipe(16, joueursSperpentard, "Serpentard", "Espagne"));

            List<Joueur> joueursPoufsouffle = new List<Joueur>();
            joueursPoufsouffle.Add(new Joueur(17, new DateTime(1999, 05, 01), "Cadwalader", "Louis", 0, PosteJoueur.Poursuiveur, 0));
            joueursPoufsouffle.Add(new Joueur(18, new DateTime(1990, 01, 05), "Smith", "Zacharias", 1, PosteJoueur.Poursuiveur, 0));
            joueursPoufsouffle.Add(new Joueur(19, new DateTime(1992, 06, 01), "Diggori", "Cedric", 12, PosteJoueur.Poursuiveur, 0));
            joueursPoufsouffle.Add(new Joueur(20, new DateTime(1991, 12, 04), "Abdel", "Achille", 9, PosteJoueur.Batteur, 0));
            joueursPoufsouffle.Add(new Joueur(21, new DateTime(1992, 11, 17), "Anelise", "Anthony", 7, PosteJoueur.Batteur, 0));
            joueursPoufsouffle.Add(new Joueur(22, new DateTime(1992, 07, 18), "Gregory", "Azaad", 7, PosteJoueur.Gardien, 0));
            joueursPoufsouffle.Add(new Joueur(23, new DateTime(1993, 03, 01), "Bahar", "Barbara", 4, PosteJoueur.Attrapeur, 0));
            _joueurs.AddRange(joueursPoufsouffle);
            _equipes.Add(new Equipe(24, joueursPoufsouffle, "Poufsouffle", "Angleterre"));

            List<Joueur> joueursSerdaigle = new List<Joueur>();
            joueursSerdaigle.Add(new Joueur(25, new DateTime(1991, 12, 01), "Cooper", "Bradley", 0, PosteJoueur.Poursuiveur, 0));
            joueursSerdaigle.Add(new Joueur(26, new DateTime(1994, 11, 03), "Chalkn", "Joe", 0, PosteJoueur.Poursuiveur, 0));
            joueursSerdaigle.Add(new Joueur(27, new DateTime(1992, 10, 01), "Davies", "Rogger", 6, PosteJoueur.Poursuiveur, 0));
            joueursSerdaigle.Add(new Joueur(28, new DateTime(1993, 09, 05), "Beshir", "Baptiste", 8, PosteJoueur.Batteur, 0));
            joueursSerdaigle.Add(new Joueur(29, new DateTime(1992, 08, 01), "Burakfe", "Caroline", 9, PosteJoueur.Batteur, 0));
            joueursSerdaigle.Add(new Joueur(30, new DateTime(1995, 07, 07), "Dupont", "Jean", 1, PosteJoueur.Gardien, 0));
            joueursSerdaigle.Add(new Joueur(31, new DateTime(1990, 06, 01), "Cihan", "Jackeline", 55, PosteJoueur.Attrapeur, 0));
            _joueurs.AddRange(joueursSerdaigle);
            _equipes.Add(new Equipe(32, joueursSerdaigle, "Serdaigle", "Brésil"));

            _stades.Add(new Stade(33, "3 chemin des vents nuageux 01600 Poudlard", "Stade de la coupe du monde", 5078, 10d));
            _stades.Add(new Stade(34, "798 rue des marais 01600 Poudlard", "Marais de Quidditch", 4485, 8d));
            _stades.Add(new Stade(35, "1 rue de l'ecole, 01600 Poudlard", "Stade de Poudlard", 9981, 5d));

            Coupe coupeDuMonde = new Coupe(36, "Coupe du monde de Quidditch", 2001, new List<Match>(), new List<Equipe>());
            Match gryVSSerp = new Match(39, coupeDuMonde.ID, new DateTime(2014, 01, 17), _equipes.ElementAt(0), _equipes.ElementAt(1), 100d, 0, 0, _stades.ElementAt(2));
            coupeDuMonde.Equipes.Add(_equipes.ElementAt(0));
            coupeDuMonde.Equipes.Add(_equipes.ElementAt(1));
            coupeDuMonde.Matchs.Add(gryVSSerp);
            Match pouVSSer = new Match(40, coupeDuMonde.ID, new DateTime(2014, 01, 18), _equipes.ElementAt(2), _equipes.ElementAt(3), 50d, 0, 0, _stades.ElementAt(1));
            coupeDuMonde.Equipes.Add(_equipes.ElementAt(2));
            coupeDuMonde.Equipes.Add(_equipes.ElementAt(3));
            coupeDuMonde.Matchs.Add(pouVSSer);
            _coupes.Add(coupeDuMonde);

            Coupe coupeDes4Maisons = new Coupe(42, "Coupe des 4 maisons", 1995, new List<Match>(), new List<Equipe>());
            Match gryVSpou = new Match(43, coupeDes4Maisons.ID, new DateTime(2014, 02, 25), _equipes.ElementAt(0), _equipes.ElementAt(2), 100d, 0, 0, _stades.ElementAt(1));
            coupeDes4Maisons.Equipes.Add(_equipes.ElementAt(0));
            coupeDes4Maisons.Equipes.Add(_equipes.ElementAt(2));
            coupeDes4Maisons.Matchs.Add(gryVSpou);
            Match SerpVSSer = new Match(44, coupeDes4Maisons.ID, new DateTime(2014, 02, 26), _equipes.ElementAt(1), _equipes.ElementAt(3), 50d, 0, 0, _stades.ElementAt(0));
            coupeDes4Maisons.Equipes.Add(_equipes.ElementAt(1));
            coupeDes4Maisons.Equipes.Add(_equipes.ElementAt(3));
            coupeDes4Maisons.Matchs.Add(SerpVSSer);
            _coupes.Add(coupeDes4Maisons);

            _reservations.Add(new Reservation(45, coupeDes4Maisons , gryVSpou, 2, 
                new Spectateur ( 46 , new DateTime(1992 , 06 , 11 ), "Bustos", "Jordan" ,
                    "12 rue de beau peyra", "jordan.bustos@gmail.com")));

            _reservations.Add(new Reservation(47, coupeDuMonde, pouVSSer, 4,
                new Spectateur(48, new DateTime(1992, 06, 11), "Raph", "Jordan",
                    "1u peyra", "jordan@gmail.com")));

        }        
    }
}
