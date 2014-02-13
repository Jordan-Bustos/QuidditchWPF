using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchWPF.ViewModel
{
    /// <summary>
    /// Le view model d'une reservation.
    /// </summary>
    public class ViewModelReservation : ViewModelBase
    {
          // Model encapsulé dans le ViewModel
        private EntitiesLayer.Reservation _reservation;

        public EntitiesLayer.Reservation Reservation
        {
            get { return _reservation; }
            private set { _reservation = value; }
        }

        private List<Coupe> _coupes;

        public ViewModelReservation(Reservation modelReservation, List<Coupe> coupes)
        {
            _reservation = modelReservation;
            _coupes = coupes;
        }

        #region "Propriétés accessibles, mappables par la View"

        public Coupe Coupe
        {
            get { return _reservation.Coupe; }
            set
            {
                if (value == _reservation.Coupe) return;
                _reservation.Coupe = value;
                base.OnPropertyChanged("Coupe");
                // Changement de la coupe entraine changement de match
                base.OnPropertyChanged("Matchs");
            }
        }

        public List<Coupe> Coupes
        {
            get { return _coupes; }
            set
            {
                if (value == _coupes) return;
                _coupes = value;
                base.OnPropertyChanged("Coupes");
            }
        }

        public Match Match
        {
            get { return _reservation.Match; }
            set
            {
                if (value == _reservation.Match) return;
                _reservation.Match = value;
                base.OnPropertyChanged("Match");
            }
        }

        public List<Match> Matchs
        {
            get { return _reservation.Coupe.Matchs; }
            set
            {
                if (value == _reservation.Coupe.Matchs) return;
                _reservation.Coupe.Matchs = value;
                base.OnPropertyChanged("Matchs");
            }
        }

        public String Nom
        {
            get { return _reservation.Spectateur.Nom; }
            set
            {
                if (value == _reservation.Spectateur.Nom) return;
                _reservation.Spectateur.Nom = value;
                base.OnPropertyChanged("Nom");
            }
        }

        public String Prenom
        {
            get { return _reservation.Spectateur.Prenom; }
            set
            {
                if (value == _reservation.Spectateur.Prenom) return;
                _reservation.Spectateur.Prenom = value;
                base.OnPropertyChanged("Prenom");
            }
        }

        public String Adresse
        {
            get { return _reservation.Spectateur.Adresse; }
            set
            {
                if (value == _reservation.Spectateur.Adresse) return;
                _reservation.Spectateur.Adresse = value;
                base.OnPropertyChanged("Adresse");
            }
        }

        public int Place
        {
            get { return _reservation.NombrePlacesReservees; }
            set
            {
                if (value == _reservation.NombrePlacesReservees) return;
                _reservation.NombrePlacesReservees = value;
                base.OnPropertyChanged("Place");
            }
        }

        #endregion
    }
}
