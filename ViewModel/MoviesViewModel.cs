using DatabaseAccess;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MultiplexTrack.Helpers;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MultiplexTrack.ViewModel
{
    public class MoviesViewModel : ViewModelBase
    {
        private MultiplexTrackDbContext databaseContext;
        private IFrameNavigationService _navigationService;

        private ObservableCollection<Category> categories;

        public MoviesViewModel(IFrameNavigationService navigationService)
        {
            databaseContext = new MultiplexTrackDbContext();
            _navigationService = navigationService;
            categories = new ObservableCollection<Category> { new Category ()};
            GetCategories();
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


        public ObservableCollection<Category> CategoriesValue { get => categories; set => Set(ref categories, value); }
        //public ObservableCollection<Category> CategoriesItems { get => categories; set => Set(ref categories, value); }

        //TODO: Selected Items (categories)

        public ObservableCollection<Category> GetCategories()
        {
            foreach (Category category in databaseContext.Category)
            {
                categories.Add(category);
            }

            return categories;
        }
    }


}