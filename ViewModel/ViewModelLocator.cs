﻿using GalaSoft.MvvmLight.Ioc;
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
            SimpleIoc.Default.Register<UserRegisterViewModel>();
            SimpleIoc.Default.Register<HomeViewModel>();
            SimpleIoc.Default.Register<MovieShowTimeModel>();
            SimpleIoc.Default.Register<MoviesViewModel>();

            SetupNavigation();
        }

        private static void SetupNavigation()
        {
            var navigationService = new FrameNavigationService();
            navigationService.Configure("UserLoginView", new Uri("../View/UserLoginView.xaml", UriKind.Relative));
            navigationService.Configure("HomeView", new Uri("../View/HomeView.xaml", UriKind.Relative));
            navigationService.Configure("MoviesView", new Uri("../View/MoviesView.xaml", UriKind.Relative));
            navigationService.Configure("UserRegisterView", new Uri("../View/UserRegisterView.xaml", UriKind.Relative));
            navigationService.Configure("MovieShowTimeView", new Uri("../View/MovieShowTimeView.xaml", UriKind.Relative));
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

        public UserRegisterViewModel UserRegisterViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<UserRegisterViewModel>();
            }
        }

        public HomeViewModel HomeViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<HomeViewModel>();
            }
        }

        public MovieShowTimeModel MovieShowTimeModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MovieShowTimeModel>();
            }
        }

        public MoviesViewModel MoviesViewModel
        { 
            get
            {
                return SimpleIoc.Default.GetInstance<MoviesViewModel>();
            }
        }
    }
}
