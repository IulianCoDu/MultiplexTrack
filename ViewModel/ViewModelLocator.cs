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
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<UserLoginViewModel>();
            SimpleIoc.Default.Register<MultiplexTrackViewModel>();

            SetupNavigation();
        }

        private static void SetupNavigation()
        {
            var navigationService = new FrameNavigationService();
            navigationService.Configure("UserLoginView", new Uri("../View/UserLoginView.xaml", UriKind.Relative));
            navigationService.Configure("MultiplexTrackView", new Uri("../View/MultiplexTrackView.xaml", UriKind.Relative));
            SimpleIoc.Default.Register<IFrameNavigationService>(() => navigationService);
        }
        public MainViewModel MainViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MainViewModel>();
            }
        }

        public UserLoginViewModel UserLoginViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<UserLoginViewModel>();
            }
        }

        public MultiplexTrackViewModel MultiplexTrackModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MultiplexTrackViewModel>();
            }
        }
    }
}
