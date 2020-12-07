using DatabaseAccess;
using GalaSoft.MvvmLight;
using MultiplexTrack.Helpers;
using System.Windows.Input;

namespace MultiplexTrack.ViewModel
{
    public class MoviesViewModel : ViewModelBase
    {
        private MultiplexTrackDbContext databaseContext;
        private IFrameNavigationService _navigationService;

        public MoviesViewModel(IFrameNavigationService navigationService)
        {
            databaseContext = new MultiplexTrackDbContext();
            _navigationService = navigationService;
        }

        public ICommand MyProperty { get; set; }
    }
}