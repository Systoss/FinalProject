using CommonServiceLocator;
using FinalProject.App.IViewModel;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Navigation;

namespace FinalProject.App.ViewModel
{
    public class LocatorViewModel
    {
        public LocatorViewModel()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<IMainPageViewModel, MainPageViewModel>();
            SimpleIoc.Default.Register<INavigationService, NavigationService>();
        }

        public IMainPageViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<IMainPageViewModel>();
            }
        }
    }
}
