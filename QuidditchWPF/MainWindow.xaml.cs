using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using QuidditchWPF.Windows;
using QuidditchWPF.Persistance;

namespace QuidditchWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Les differentes fenetres de l'application.
        /// </summary>
        private GestionDesCoupes _winGestionDesCoupes;
        private GestionDesEquipes _winGestionDesEquipes;
        private GestionDesJoueurs _winGestionDesJoueurs;
        private GestionDesStades _winGestionDesStades;
        private GestionDesMatchs _winGestionDesMatchs;
        private GestionDesReservations _winGestionDesReservations;


        /// <summary>
        /// Constructeur de la fenetre principale.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
         
        }

        /// <summary>
        /// Permet de recuerer l'evenement de clique sur le bouton des coupes.
        /// </summary>
        /// <param name="sender">???</param>
        /// <param name="e">???</param>
        private void bpCoupes_Click(object sender, RoutedEventArgs e)
        {
            _winGestionDesCoupes = new GestionDesCoupes();
            // On defini la MainWindow comme Owner de la fenetre de gestion des coupes
            _winGestionDesCoupes.Owner = this;
            // On desactive la MainWindow puis on affiche la fenetre de gestion des coupes
            this.IsEnabled = false;
            _winGestionDesCoupes.Show();
        }

        /// <summary>
        /// Permet de recuerer l'evenement de clique sur le bouton des equipes.
        /// </summary>
        /// <param name="sender">???</param>
        /// <param name="e">???</param>
        private void bpEquipes_Click(object sender, RoutedEventArgs e)
        {
            _winGestionDesEquipes = new GestionDesEquipes();
            // On defini la MainWindow comme Owner de la fenetre de gestion des equipes
            _winGestionDesEquipes.Owner = this;
            // On desactive la MainWindow puis on affiche la fenetre de gestion des equipes
            this.IsEnabled = false;
            _winGestionDesEquipes.Show();
        }

        /// <summary>
        /// Permet de recuerer l'evenement de clique sur le bouton des joueurs.
        /// </summary>
        /// <param name="sender">???</param>
        /// <param name="e">???</param>
        private void bpJoueurs_Click(object sender, RoutedEventArgs e)
        {
            _winGestionDesJoueurs = new GestionDesJoueurs();
            // On defini la MainWindow comme Owner de la fenetre de gestion des joueurs
            _winGestionDesJoueurs.Owner = this;
            //On desactive la MainWindow puis on affiche la fenetre de gestion des joueurs
            this.IsEnabled = false;
            _winGestionDesJoueurs.Show();
        }

        /// <summary>
        /// Permet de recuerer l'evenement de clique sur le bouton des stades.
        /// </summary>
        /// <param name="sender">???</param>
        /// <param name="e">???</param>
        private void bpStades_Click(object sender, RoutedEventArgs e)
        {
            _winGestionDesStades = new GestionDesStades();
            // On defini la MainWindow comme Owner de la fenetre de gestion des stades
            _winGestionDesStades.Owner = this;
            //On desactive la MainWindow puis on affiche la fenetre de gestion des stades
            this.IsEnabled = false;
            _winGestionDesStades.Show();
        }

        /// <summary>
        /// Permet de recuerer l'evenement de clique sur le bouton des matchs.
        /// </summary>
        /// <param name="sender">???</param>
        /// <param name="e">???</param>
        private void bpMatchs_Click(object sender, RoutedEventArgs e)
        {
            _winGestionDesMatchs = new GestionDesMatchs();
            // On defini la MainWindow comme Owner de la fenetre de gestion des matchs
            _winGestionDesMatchs.Owner = this;
            //On desactive la MainWindow puis on affiche la fenetre de gestion des matchs
            this.IsEnabled = false;
            _winGestionDesMatchs.Show();
        }

        /// <summary>
        /// Permet de recuerer l'evenement de clique sur le bouton des reservations..
        /// </summary>
        /// <param name="sender">???</param>
        /// <param name="e">???</param>
        private void bpReservation_Click(object sender, RoutedEventArgs e)
        {
            _winGestionDesReservations = new GestionDesReservations();
            // On defini la MainWindow comme Owner de la fenetre de gestion des matchs
            _winGestionDesReservations.Owner = this;
            //On desactive la MainWindow puis on affiche la fenetre de gestion des matchs
            this.IsEnabled = false;
            _winGestionDesReservations.Show();
        }

        /// <summary>
        /// Evenement en cours de fermeture de la fenetre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveDimensions.GetInstance().saveDimensionsFenetre(this);
            SaveDimensions.GetInstance().SaveFenetresProperties();
        }

        /// <summary>
        /// Evenement fenetre chargee.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            SaveDimensions.GetInstance().LoadFenetresProperties();
            SaveDimensions.GetInstance().loadDimensionsFenetre(this);
        }
    }
}
