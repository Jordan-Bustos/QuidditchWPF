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
    /// Logique d'interaction pour GestionDesMatchs.xaml
    /// </summary>
    public partial class GestionDesMatchs : Window
    {
        /// <summary>
        /// Constructeur de la fenetre de gestion des matchs.
        /// </summary>
        public GestionDesMatchs()
        {
            InitializeComponent();

            // On recupere la liste des coupes et on les charge dans la liste box
            var coupes = new List<Coupe>();
            coupes = BusinessManager.getCoupes();
            coupes.Sort();
            cbCoupes.ItemsSource = coupes;

            // On initialise la liste des joueurs avec la premiere equipe
            cbCoupes_SelectionChanged(cbCoupes, null);
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
        private void cbCoupes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // On recupere la liste des matchs de la coupe selectionnee, et on les affiches.
            var coupe = (sender as ComboBox).SelectedItem as Coupe;
            var matchs = new List<Match>();
            matchs = coupe.Matchs;
            matchs.Sort();
            lvMatchs.ItemsSource = matchs;
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
