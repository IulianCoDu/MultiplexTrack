using DatabaseAccess;
using GalaSoft.MvvmLight;
using MultiplexTrack.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MultiplexTrack.ViewModel
{
    public class MovieShowTimeModel : ViewModelBase
    {
        private MultiplexTrackDbContext databaseContext;
        private IFrameNavigationService _navigationService;
        public  MovieShowTimeModel(IFrameNavigationService navigationService)
        {
            databaseContext = new MultiplexTrackDbContext();
            _navigationService = navigationService;
        }
    }
}
