using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MultiplexTrack.Helpers;
using System;
using System.Windows;
using System.Windows.Input;

namespace MultiplexTrack.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IFrameNavigationService _navigationService;
        private RelayCommand _loadedCommand;
        private ICommand _homeViewCommand;
        private ICommand _moviesShowTimeCommand;
        private ICommand _moviesViewCommand;
        private ICommand _closeCommand;

        public MainViewModel(IFrameNavigationService navigationService)
        {
            _navigationService = navigationService;

            CloseCommand = new RelayCommand(() => Close());
        }

        public RelayCommand LoadedCommand
        {
            get
            {
                return _loadedCommand
                    ?? (_loadedCommand = new RelayCommand(
                    () =>
                    {
                        _navigationService.NavigateTo("UserLoginView");
                    }));
            }
        }

        public ICommand CloseCommand
        {
            get { return _closeCommand; }
            set { Set(ref _closeCommand, value); }
        }

        public void Close()
        {
            Application.Current.Shutdown();
        }

        public ICommand HomeViewCommand
        {
            get { return new RelayCommand(() =>
                {
                    _navigationService.NavigateTo("HomeView");
                }
                );}
            set {Set (ref _homeViewCommand, value); }
        }

        public ICommand MoviesShowTimeCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    _navigationService.NavigateTo("MovieShowTimeView");
                }
                );
            }
            set { Set(ref _moviesShowTimeCommand, value); }
        }

        public ICommand MoviesViewCommand
        {
            get {
                return new RelayCommand(() =>
                {
                    _navigationService.NavigateTo("MoviesView");
                }
                );}
            set { Set (ref _moviesViewCommand, value); }
        }


    }
}
