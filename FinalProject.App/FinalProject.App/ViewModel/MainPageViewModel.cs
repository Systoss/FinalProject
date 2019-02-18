using FinalProject.App.IViewModel;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Navigation;

namespace FinalProject.App.ViewModel
{
    public class MainPageViewModel : ViewModelBase, IMainPageViewModel
    {
        private INavigationService _iNavigationService;
        public MainPageViewModel(INavigationService iNavigationService)
        {
            _iNavigationService = iNavigationService;
        }
    }
}
