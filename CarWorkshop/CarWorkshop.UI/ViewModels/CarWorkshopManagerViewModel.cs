using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace CarWorkshop.UI.ViewModels
{
    public class CarWorkshopManagerViewModel : ViewModelBase
    {
        private readonly IDataProvider<Models.CarWorkshop> _carWorkshopProvider;
        private CarWorkshopViewModel _currentCarWorkshop;
        private ObservableCollection<CarWorkshopViewModel> _carWorkshops;
        private int _selectedIndex;
        private string _selectedCity;

        public RelayCommand UpdateCommand { get; }
        public RelayCommand RemoveCommand { get; }
        public RelayCommand AddCommand { get; }

        public CarWorkshopManagerViewModel(IDataProvider<Models.CarWorkshop> provider)
        {
            UpdateCommand = new RelayCommand(UpdateCommandExecute);
            RemoveCommand = new RelayCommand(RemoveCommandExecute);
            AddCommand = new RelayCommand(AddCommandExecute);
            _carWorkshopProvider = provider;
        }

        public ObservableCollection<CarWorkshopViewModel> CarWorkshops
        {
            get { return _carWorkshops; }
            set
            {
                _carWorkshops = value;
                RaisePropertyChanged(nameof(CarWorkshops));
            }
        }

        public CarWorkshopViewModel CurrentCarWorkshop
        {
            get { return _currentCarWorkshop; }
            set
            {
                _currentCarWorkshop = value;
                RaisePropertyChanged(nameof(CurrentCarWorkshop));
            }
        }

        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set { _selectedIndex = value; }
        }

        public IEnumerable<string> Cities => GetAllCities();

        public string SelectedCity
        {
            get { return _selectedCity; }
            set
            {
                _selectedCity = value;
                RaisePropertyChanged(nameof(SelectedCity));
                SortCarWorkshopsByCity();
            }
        }

        private void UpdateCommandExecute()
        {
            _carWorkshopProvider.UpdateItem(CurrentCarWorkshop.Workshop);
            _carWorkshops[_selectedIndex] = _currentCarWorkshop;
        }

        private void RemoveCommandExecute()
        {
            _carWorkshopProvider.RemoveItem(CurrentCarWorkshop.Workshop);
            _carWorkshops.RemoveAt(_selectedIndex);
        }

        private void AddCommandExecute()
        {
            if (true) // check unique fields
            {
                _carWorkshopProvider.AddItem(CurrentCarWorkshop.Workshop);
                _carWorkshops.Add(_currentCarWorkshop);
            }
        }

        private IEnumerable<string> GetAllCities()
        {
            var cities = _carWorkshopProvider.GetData().Select(x => x.City);
            return cities;
        }

        private void SortCarWorkshopsByCity()
        {
            CarWorkshops = new ObservableCollection<CarWorkshopViewModel>(CarWorkshops.Where(x => x.City.Equals(SelectedCity)));
        }
    }
}
