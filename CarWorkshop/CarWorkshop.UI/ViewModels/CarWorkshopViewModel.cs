using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWorkshop.Models;
using GalaSoft.MvvmLight;

namespace CarWorkshop.UI.ViewModels
{
    public class CarWorkshopViewModel : ViewModelBase
    {
        private Models.CarWorkshop _carWorkshop;

        public string CompanyName
        {
            get { return Workshop.CompanyName; }
            set
            {
                if (Workshop.CompanyName != value)
                {
                    Workshop.CompanyName = value;
                    RaisePropertyChanged(nameof(CompanyName));
                }
            }
        }

        public string City
        {
            get { return Workshop.City; }
            set
            {
                if (Workshop.City != value)
                {
                    Workshop.City = value;
                    RaisePropertyChanged(nameof(City));
                }
            }
        }

        public string PostalCode
        {
            get { return Workshop.PostalCode; }
            set
            {
                if (Workshop.PostalCode != value)
                {
                    Workshop.PostalCode = value;
                    RaisePropertyChanged(nameof(PostalCode));
                }
            }
        }

        public List<string> CarTrademarks
        {
            get { return Workshop.CarTrademarks; }
            set
            {
                Workshop.CarTrademarks = value;
                RaisePropertyChanged(nameof(CarTrademarks));
            }
        }

        public string Country
        {
            get { return Workshop.Country; }
            set
            {
                if (Workshop.Country != value)
                {
                    Workshop.Country = value;
                    RaisePropertyChanged(nameof(Country));
                }
            }
        }

        public Models.CarWorkshop Workshop
        {
            get { return _carWorkshop; }
            set { _carWorkshop = value; }
        }
    }
}
