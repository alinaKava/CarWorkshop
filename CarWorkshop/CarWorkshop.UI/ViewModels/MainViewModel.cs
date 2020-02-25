using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWorkshop.UI.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace CarWorkshop.UI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private CarWorkshopManagerViewModel _carWorkshopManager;

        public RelayCommand OpenCarWorkshopsCommand { get; }
        public RelayCommand OpenUsersCommand { get; }
        public RelayCommand OpenAppointmentsCommand { get; }

        // todo: use ViewModelLocator
        public MainViewModel(IDataProvider<Models.CarWorkshop> carWorkShopProvider, 
            IDataProvider<Models.User> userProvider, IDataProvider<Models.Appointment> appointmentProvider)
        {
            _carWorkshopManager = new CarWorkshopManagerViewModel(carWorkShopProvider);
            OpenCarWorkshopsCommand = new RelayCommand(OpenCarWorkshopsCommandExecute);
            OpenUsersCommand = new RelayCommand(OpenUsersCommandExecute);
            OpenAppointmentsCommand = new RelayCommand(OpenAppointmentsCommandExecute);
        }

        private void OpenAppointmentsCommandExecute()
        {
            throw new NotImplementedException();
        }

        private void OpenUsersCommandExecute()
        {
            throw new NotImplementedException();
        }

        private void OpenCarWorkshopsCommandExecute()
        {
            CarWorkshopView window = new CarWorkshopView {DataContext = _carWorkshopManager};
            window.Show();
        }
    }
}
