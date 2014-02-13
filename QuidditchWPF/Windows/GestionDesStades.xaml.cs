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
    /// Logique d'interaction pour GestionDesStades.xaml
    /// </summary>
    public partial class GestionDesStades : Window
    {
        /// <summary>
        /// Constructeur de la fenetre de gestion des stades.
        /// </summary>
        public GestionDesStades()
        {
            InitializeComponent();

            // On recupere la liste des equipes et de l'afficher
            var stades = new List<Stade>();
            stades = BusinessManager.getStades();
            stades.Sort();
            lvStades.ItemsSource = stades;
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
