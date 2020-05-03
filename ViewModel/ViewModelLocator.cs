using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using MultiplexTrack.Helpers;
using System;

namespace MultiplexTrack.ViewModel
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            //TODO
            //ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<UserViewModel>();
            SetupNavigation();
        }

        private static void SetupNavigation()
        {
            var navigationService = new FrameNavigationService();
            navigationService.Configure("Home", new Uri("../View/UserRegisterView.xaml", UriKind.Relative));
            navigationService.Configure("Page1", new Uri("../View/UserLoginView.xaml", UriKind.Relative));
            SimpleIoc.Default.Register<IFrameNavigationService>(() => navigationService);
        }
        public MainViewModel MainViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public UserViewModel UserViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<UserViewModel>();
            }
        }
    }
}
