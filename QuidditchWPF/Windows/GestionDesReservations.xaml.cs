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
    /// Logique d'interaction pour GestionDesReservations.xaml
    /// </summary>
    public partial class GestionDesReservations : Window
    {
        /// <summary>
        /// Constructeur de la fenetre de gestion des reservations.
        /// </summary>
        public GestionDesReservations()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Permet de reactiver la fenetre principale, et de sauvagerder les dimensions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveDimensions.GetInstance().saveDimensionsFenetre(this);

            // On reactive la fenetre mere (MainWindow)
            this.Owner.IsEnabled = true;
        }

        /// <summary>s
        /// Evenement fenetre chargee.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            SaveDimensions.GetInstance().loadDimensionsFenetre(this);

            // récupération des reservations et des coupes
            IList<EntitiesLayer.Reservation> reservations = BusinessLayer.BusinessManager.getReservations();
            List<EntitiesLayer.Coupe> coupes = BusinessLayer.BusinessManager.getCoupes();

            // Initialisation du viewModel

            ViewModel.ViewModelReservations avm = new QuidditchWPF.ViewModel.ViewModelReservations(reservations,coupes);
            avm.CloseNotified += CloseNotified;
            matchsReservations.DataContext = avm;
        }

        private void CloseNotified(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            ViewModel.ViewModelReservations avm = null;

            // On recupère le viewModel et on désinscrit l'event
            avm = (ViewModel.ViewModelReservations)matchsReservations.DataContext;
            if (avm != null) avm.CloseNotified -= CloseNotified;
        }
    }
}
