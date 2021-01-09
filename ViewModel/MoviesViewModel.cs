using DatabaseAccess;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;
using MultiplexTrack.Helpers;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace MultiplexTrack.ViewModel
{
    public class MoviesViewModel : ViewModelBase
    {
        private MultiplexTrackDbContext _databaseContext;
        private IFrameNavigationService _navigationService;

        private ICommand _loadPoster;
        private string _fileName;
        private ObservableCollection<Category> _categories;
        private string _title;
        private string _year;
        private string _time;
        private string _description;
        private ICommand _saveMovie;

        public MoviesViewModel(IFrameNavigationService navigationService)
        {
            _databaseContext = new MultiplexTrackDbContext();
            _navigationService = navigationService;

            _categories = new ObservableCollection<Category> { new Category() };
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
            set => Set(ref _loadPoster, value);
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

        public ObservableCollection<Category> Categories
        {
            get => GetCategories();
            set => Set(ref _categories, value);
        }
        public ObservableCollection<Category> GetCategories()
        {
            foreach (Category category in _databaseContext.Category)
            {
                _categories.Add(category);
            }
            return _categories;
        }

        public string Title
        {
            get { return _title; }
            set { Set(ref _title, value); }
        }

        public string Year
        {
            get { return _year; }
            set { Set(ref _year, value); }
        }

        public string TimeDuration
        {
            get { return _time; }
            set { Set(ref _time, value); }
        }

        public string Description
        {
            get { return _description; }
            set { Set(ref _description, value); }
        }

        public ICommand SaveMovie
        {
            get => new RelayCommand(() =>
            {
                if (FileName != null && Title != null && Year != null && TimeDuration != null && Description != null)
                {
                    //if (_databaseContext.Movie.Any())
                    //{

                    //}
                    Movie movie = new Movie();

                    movie.Poster = FileName;
                    movie.Title = Title;
                    foreach (var category in _categories)
                    {
                        //movie.Category = category.CategoryName;
                    }
                    movie.Category = _categories;
                    movie.Year = Year;
                    movie.Duration = TimeDuration;
                    movie.Description = Description;

                    //_databaseContext.Movie.

                    Clear();
                    return;
                }
                else
                {
                    MessageBox.Show("All fields are mandatory");
                }

            });
            set { Set(ref _saveMovie, value); }
        }

        private void Clear()
        {
            if (FileName != null && Title != null && Categories != null && Year != null && TimeDuration != null && Description != null)
            {
                FileName = null;
                Title = null;
                //Categories = null;
                Year = null;
                TimeDuration = null;
                Description = null;
            }
        }
    }
}