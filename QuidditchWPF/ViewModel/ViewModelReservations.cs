using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using EntitiesLayer;


namespace QuidditchWPF.ViewModel
{
    /// <summary>
    /// La view model des reservations.
    /// </summary>
    public class ViewModelReservations : ViewModelBase
    {
        // Event destiné à réclamer la fermeture du conteneur;
        public event EventHandler<EventArgs> CloseNotified;
        protected void OnCloseNotified(EventArgs e)
        {
            this.CloseNotified(this, e);
        }

        // Model encapsulé dans le ViewModel
        private ObservableCollection<ViewModelReservation> _reservations;

        public ObservableCollection<ViewModelReservation> Reservations
        {
            get { return _reservations; }
            private set 
            { 
                _reservations = value;
                OnPropertyChanged("Reservations");
            }
        }

        private List<Coupe> _coupes;

        private ViewModelReservation _selectedItem;
        public ViewModelReservation SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public ViewModelReservations(IList<EntitiesLayer.Reservation> modelReservation, List<Coupe> coupes) 
        {
            _coupes = coupes;
            _reservations = new ObservableCollection<ViewModelReservation>();
            foreach (EntitiesLayer.Reservation r in modelReservation) 
            {
                _reservations.Add(new ViewModelReservation(r,coupes)); 
            }
        }


        #region "Commandes du formulaire"

        // Commande Add
        private RelayCommand _addCommand;
        public System.Windows.Input.ICommand AddCommand
        {
            get
            {
                if (_addCommand == null)
                {
                    _addCommand = new RelayCommand(
                        () => this.Add(),
                        () => this.CanAdd()
                        );
                }
                return _addCommand;
            }
        }

        private bool CanAdd()
        {
            return true;
        }

        private void Add()
        {
            EntitiesLayer.Reservation r = new EntitiesLayer.Reservation();

            this.SelectedItem = new ViewModelReservation(r,_coupes);
            Reservations.Add(this.SelectedItem);
        }

        // Commande Remove
        private RelayCommand _removeCommand;
        public System.Windows.Input.ICommand RemoveCommand
        {
            get
            {
                if (_removeCommand == null)
                {
                    _removeCommand = new RelayCommand(
                        () => this.Remove(),
                        () => this.CanRemove()
                        );
                }
                return _removeCommand;
            }
        }

        private bool CanRemove()
        {
            return (this.SelectedItem != null);
        }

        private void Remove()
        {
            if (this.SelectedItem != null) Reservations.Remove(this.SelectedItem);
        }

        #endregion
    }

}