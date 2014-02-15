using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    /// <summary>
    /// Implementation SQL Serveur de l'accès à la base.
    /// </summary>
    public class SqlDataBase : AbstractDal
    {
        /// <summary>
        /// La chaine de connexion vers la base.
        /// </summary>
        private string _connexionString;
        
        /// <summary>
        /// Constructeur.
        /// </summary>
        public SqlDataBase()
        {
            _connexionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bubu\Documents\database.mdf;Integrated Security=True;Connect Timeout=30";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private DataTable Select(String request)
        {
            DataTable resultats = new DataTable();
            using (SqlConnection sqlConnexion= new SqlConnection(_connexionString))
            {
                SqlCommand command = new SqlCommand(request, sqlConnexion);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(resultats);
            }
            return resultats;
        }

        /// <summary>
        /// Permet de recuperer les coupes.
        /// </summary>
        /// <returns>Les coupes.</returns>
        public List<Coupe> getCoupes()
        {
            List<Coupe> coupes = new List<Coupe>();
            List<Match> allMatchs = getMatchs();
            List<Equipe> allEquipes = getEquipes();
            DataTable resultats = Select("SELECT * FROM Coupes");

            foreach (DataRow row in resultats.Rows)
            {
                int IDCoupe = (int)row["ID"];

                List<Match> matchs = new List<Match>(from match in allMatchs
                                         where match.CoupeID == IDCoupe
                                         select match);
                List<Equipe> equipes = new List<Equipe>((from match in matchs
                                                        where match.CoupeID == IDCoupe
                                                        select match.EquipeDomicile)
                                                        .Union(
                                                        from match in matchs
                                                        where match.CoupeID == IDCoupe
                                                        select match.EquipeVisiteur
                                                        ));
                Coupe coupe = new Coupe(IDCoupe, (String)row["Titre"], (int)row["Annee"], matchs, equipes);

                coupes.Add(coupe);
            }

            return coupes;
        }

        /// <summary>
        /// Permet de recuperer les equipes.
        /// </summary>
        /// <returns>Les equipes.</returns>
        public List<Equipe> getEquipes()
        {
            return new List<Equipe>();
        }

        /// <summary>
        /// Permet de recuperer les joueurs.
        /// </summary>
        /// <returns>Les joueurs.</returns>
        public List<Joueur> getJoueurs()
        {
            return new List<Joueur>();
        }

        /// <summary>
        /// Permet de recuperer les matchs.
        /// </summary>
        /// <returns>Les matchs.</returns>
        public List<Match> getMatchs()
        {
            return new List<Match>();
        }

        /// <summary>
        /// Permet de recuperer les stades.
        /// </summary>
        /// <returns>Les stades.</returns>
        public List<Stade> getStades()
        {
            return new List<Stade>();
        }

        /// <summary>
        /// Permet de recuperer les reservation.
        /// </summary>
        /// <returns>Les reservations.</returns>
        public List<Reservation> getReservations()
        {
            return new List<Reservation>();
        }
    }
}
