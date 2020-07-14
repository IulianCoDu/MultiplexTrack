using DatabaseAccess;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MultiplexTrack.Helpers;
using System.Windows.Input;

namespace MultiplexTrack.ViewModel
{
    public class MultiplexTrackViewModel : ViewModelBase
    {
        private MultiplexTrackDbContext databaseContext;
        private IFrameNavigationService _navigationService;

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

        public MultiplexTrackViewModel(IFrameNavigationService navigationService)
        {
            databaseContext = new MultiplexTrackDbContext();
            _navigationService = navigationService;

            //_toggleButtonHome = true;
        }
    }

}
