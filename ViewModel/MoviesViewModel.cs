using DatabaseAccess;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;
using MultiplexTrack.Helpers;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace MultiplexTrack.ViewModel
{
    public class MoviesViewModel : ViewModelBase
    {
        private MultiplexTrackDbContext databaseContext;
        private IFrameNavigationService _navigationService;

        private ICommand _loadPoster;
        BitmapImage _bitmapImage = new BitmapImage();

        private ObservableCollection<Category> categories;
        private string _fileName;
        private string _title;
        private string _description;


        public MoviesViewModel(IFrameNavigationService navigationService)
        {
            databaseContext = new MultiplexTrackDbContext();
            _navigationService = navigationService;
            categories = new ObservableCollection<Category> { new Category() };
        }

        public ICommand LoadPosterCommand
        {
            get => new RelayCommand(() =>
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Title = "Select a poster for movie";
                op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                    "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                    "Portable Network Graphic (*.png)|*.png";
                op.ValidateNames = true;
                op.Multiselect = false;

                if (op.ShowDialog() == true)
                {
                    FileName = op.FileName;
                }
            });
            set
            {
                Set(ref _loadPoster, value);
            }
        }


        public string FileName
        {
            get { return _fileName; }
            set
            {
                if (_fileName != value)
                {
                    _fileName = value;
                    RaisePropertyChanged("FileName");
                }

            }
        }

        public ObservableCollection<Category> CategoriesValue
        {
            get => GetCategories();
            set => Set(ref categories, value);
        }

        public string Title
        {
            get { return _title; }
            set { Set(ref _title, value); }
        }

        public string Description
        {
            get { return _description; }
            set { Set(ref _description, value); }
        }
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