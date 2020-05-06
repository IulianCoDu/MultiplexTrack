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
            navigationService.Configure("UserRegisterView", new Uri("../View/UserRegisterView.xaml", UriKind.Relative));
            navigationService.Configure("UserLoginView", new Uri("../View/UserLoginView.xaml", UriKind.Relative));
            SimpleIoc.Default.Register<IFrameNavigationService>(() => navigationService);
        }
        public MainViewModel MainViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MainViewModel>();
            }
        }

        public UserViewModel UserViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<UserViewModel>();
            }
        }
    }
}
