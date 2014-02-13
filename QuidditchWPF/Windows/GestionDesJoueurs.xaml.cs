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
using System.Windows.Shapes;

using EntitiesLayer;
using BusinessLayer;
using QuidditchWPF.Persistance;

namespace QuidditchWPF.Windows
{
    /// <summary>
    /// Logique d'interaction pour GestionDesJoueurs.xaml
    /// </summary>
    public partial class GestionDesJoueurs : Window
    {
        /// <summary>
        /// Constructeur de la fenetre de gestion des joueurs.
        /// </summary>
        public GestionDesJoueurs()
        {
            InitializeComponent();

            // On recupere la liste des equipes et on les charge dans la liste box
            var equipes = new List<Equipe>();
            equipes = BusinessManager.getEquipes();
            equipes.Sort();
            cbEquipes.ItemsSource = equipes;

            // On initialise la liste des joueurs avec la premiere equipe
            cbEquipes_SelectionChanged(cbEquipes, null);
        }

        /// <summary>
        /// Permet de reactiver la fenetre principale, et de sauvagerder les dimensions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveDimensions.GetInstance().saveDimensionsFenetre(this);

            // On reactive la fenetre mere (MainWindow)
            this.Owner.IsEnabled = true;
        }

        /// <summary>
        /// Permet de recuperer l'evenement qui indique qu'on a selectionne un item dans la liste box.
        /// </summary>
        /// <param name="sender">???</param>
        /// <param name="e">???</param>
        private void cbEquipes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // On recupere la liste des joueurs de l'equipe selectionnee, et on les affiches.
            var equipe = (sender as ComboBox).SelectedItem as Equipe;
            var joueurs = new List<Joueur>();
            joueurs = equipe.Joueurs;
            joueurs.Sort();
            lvJoueurs.ItemsSource = joueurs;
        }

        /// <summary>
        /// Evenement fenetre chargee.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SaveDimensions.GetInstance().loadDimensionsFenetre(this);
        }
    }
}
