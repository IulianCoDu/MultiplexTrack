using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MultiplexTrack.Helpers;
using System.Windows.Input;

namespace MultiplexTrack.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IFrameNavigationService _navigationService;
        private RelayCommand _loadedCommand;
        private ICommand _homeViewCommand;
        
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

        public MainViewModel(IFrameNavigationService navigationService)
        {
            _navigationService = navigationService;
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

    }
}
