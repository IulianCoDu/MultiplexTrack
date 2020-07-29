using DatabaseAccess;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MultiplexTrack.Helpers;
using System.Windows.Input;

namespace MultiplexTrack.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {
        private MultiplexTrackDbContext databaseContext;
        private IFrameNavigationService _navigationService;
        private ICommand _moviesCommand;


        public HomeViewModel(IFrameNavigationService navigationService)
        {
            databaseContext = new MultiplexTrackDbContext();
            _navigationService = navigationService;

            //_toggleButtonHome = true;
        }

        public ICommand MoviesCommand
        {
            get 
            {
                return new RelayCommand( () =>
                {
                    _navigationService.NavigateTo("MoviesView");
                });
            }
            set { Set(ref _moviesCommand, value); }
        }


        

        //private ICommand _toggleButtonHome;
        //public ICommand HomeToggleButton()
        //{
        //    get
        //    {
        //        return new RelayCommand( () =>
        //        {
        //            bool test= true;
        //        });
        //    }
        //    set { Set(ref _toggleButtonHome, value); } // TODO: Read about this custom Set
        //}

        private bool _toggleButtonHome;
        public bool HomeButton
        {
            get { return _toggleButtonHome; }
            set { Set(ref _toggleButtonHome, value); }
        }


    }

}
