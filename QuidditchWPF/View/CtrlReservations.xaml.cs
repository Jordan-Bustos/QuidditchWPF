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
using EntitiesLayer;
using BusinessLayer;
using QuidditchWPF.ViewModel;

namespace QuidditchWPF.View
{
    /// <summary>
    /// Logique d'interaction pour CtrlReservations.xaml
    /// </summary>
    public partial class CtrlReservations : UserControl
    {
        public CtrlReservations()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvReservations_Loaded(object sender, RoutedEventArgs e)
        {
            /*List<ViewModelReservation> reservations = new List<ViewModelReservation>();
            List<Coupe> coupes = BusinessLayer.BusinessManager.getCoupess();

            foreach (Reservation r in BusinessLayer.BusinessManager.getReservations())
            {
                reservations.Add(new ViewModelReservation(r,coupes));
            }*/

            List<Coupe> coupes = BusinessLayer.BusinessManager.getCoupes();
            ViewModelReservations reservations = new ViewModelReservations(BusinessLayer.BusinessManager.getReservations(), coupes);
            this.DataContext = reservations;
        }
    }
}
