using DatabaseAccess;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;
using MultiplexTrack.Helpers;
using System.Collections.Generic;
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

        private ObservableCollection<Category> _categories;
        private ObservableCollection<Category> _selectedCategories;

        private ICommand _loadPoster;
        private string _fileName;
        private string _title;
        private string _year;
        private string _time;
        private string _description;
        private ICommand _saveMovie;

        public MoviesViewModel(IFrameNavigationService navigationService)
        {
            _databaseContext = new MultiplexTrackDbContext();
            _navigationService = navigationService;

            _categories = new ObservableCollection<Category>();
            _selectedCategories = new ObservableCollection<Category>();

            _loadPoster = new RelayCommand(() =>
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

            _saveMovie = new RelayCommand(ExecuteSaveMovie);
        }

        public ICommand LoadPosterCommand
        {
            get => _loadPoster;
            set => Set(ref _loadPoster, value);
        }

        public string FileName
        {
            get { return _fileName; }
            set
            {
                if (_fileName != value)
                {
                    Set(ref _fileName, value);
                }
            }
        }

        public ObservableCollection<Category> CategoriesSource
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

        public ObservableCollection<Category> SelectedCategories
        {
            get { return _selectedCategories; }
            set { Set(ref _selectedCategories, value); }
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
            get => _saveMovie;
            set { Set(ref _saveMovie, value); }
        }

        private void Clear()
        {
            if (FileName != null && Title != null && Year != null && TimeDuration != null && Description != null)
            {
                FileName = null;
                Title = null;
                //_databaseContext.Category.RemoveRange(_categories);
                Year = null;
                TimeDuration = null;
                Description = null;
            }
        }

        private void ExecuteSaveMovie()
        {
            if (FileName != null && Title != null && SelectedCategories != null && Year != null && TimeDuration != null && Description != null)
            {
                Movie movie = new Movie();
                movie.Poster = FileName;
                movie.Title = Title;
                movie.Category = SelectedCategories;
                movie.Year = Year;
                movie.Duration = TimeDuration;
                movie.Description = Description;
                movie.User = LoggedInUser.CurrentUser;

                movie.MovieShowtime = null;

                _databaseContext.Movie.Add(movie);
                try
                {
                    _databaseContext.SaveChanges();
                }
                catch (System.Exception)
                {

                    throw;
                }

                Clear();
                return;
            }
            else
            {
                MessageBox.Show("All fields are mandatory");
            }
        }

    }
}