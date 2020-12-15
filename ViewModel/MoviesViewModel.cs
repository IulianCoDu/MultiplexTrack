using DatabaseAccess;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MultiplexTrack.Helpers;
using System.Collections.Generic;

namespace MultiplexTrack.ViewModel
{
    public class MoviesViewModel : ViewModelBase
    {
        private MultiplexTrackDbContext databaseContext;
        private IFrameNavigationService _navigationService;

        private string _categoryType;
        // private new IList<Category> _categoryType;
        //private ICommand _categoryType;


        public MoviesViewModel(IFrameNavigationService navigationService)
        {
            databaseContext = new MultiplexTrackDbContext();
            _navigationService = navigationService;
        }

        //public ICommand ShowMovieType
        //{
        //    get => new RelayCommand(() =>
        //    {
        //        //GetCategories();
        //        foreach (Category _category in databaseContext.Category)

        //        {
        //            //_categoryType.Add(_category);
        //        }
        //    });
        //    set { Set(ref _categoryType, value); }
        //}

        public IList<Category> Categories { get; set; }



        public string CategoriesType
        {
            get { return _categoryType; }
            set { Set(ref _categoryType, value); }
        }

        public IList<Category> GetCategories()
        {
            IList<Category> categories = new List<Category>();
            for (int i = 0; i < categories.Count; i++)
            {
                //_categoryType.Add(categories);
            }
            return categories;
        }
    }

    
}