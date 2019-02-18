using FinalProject.App.IViewModel;
using FinalProject.App.Service;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Navigation;

namespace FinalProject.App.ViewModel
{
    public class MainPageViewModel : ViewModelBase, IMainPageViewModel
    {
        private INavigationService _iNavigationService;
        private string selectedAdresse;

        public string SelectedAdresse
        {
            get {
                return selectedAdresse;
            }
            set {

                selectedAdresse = value;
                Set(() => SelectedAdresse, ref selectedAdresse, value);
                RaisePropertyChanged("SelectedAdresse");
            }
        }

        private string coordonnee;

        public string Coordonnee
        {
            get
            {
                return coordonnee;
            }
            set
            {
                coordonnee = value;
                Set(() => Coordonnee, ref coordonnee, value);
                RaisePropertyChanged("Coordonnee");
            }
        }

        public ICommand GetCoordonneCommand { get; set; }
        public MainPageViewModel(INavigationService iNavigationService)
        {
            _iNavigationService = iNavigationService;
            GetCoordonneCommand = new Command<String>(GetCoordonne);
        }

        private async void GetCoordonne(string obj)
        {
            Coordonnee = await GPSService.Get(SelectedAdresse);
        }
    }
}
