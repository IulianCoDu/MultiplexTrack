using DatabaseAccess;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MultiplexTrack.Helpers;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace MultiplexTrack.ViewModel
{
    class UserRegisterViewModel : ViewModelBase
    {
        private MultiplexTrackDbContext databaseContext;
        private IFrameNavigationService _navigationService;

        private string _userName;
        private string _password;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _isVisible;
        private ICommand _saveCommand;

        public UserRegisterViewModel(IFrameNavigationService frameNavigationService)
        {
            
        }

        public string UserNameText
        {
            get { return _userName; }
            set { Set(ref _userName, value); }
        }
        public string PasswordText
        {
            get { return _password; }
            set { Set(ref _password, value); }
        }

        public ICommand SaveCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    //TODO: Save User and Password into the database, then navigate to next View to fill up the extra info
                    if (databaseContext.User.Any(name => name.UserName == UserNameText))
                    {
                        MessageBox.Show("User already exists!");
                        return;
                    }
                    else
                    {
                        //_navigationService.NavigateTo("UserRegisterView");

                        while (FirstNameText != null && LastNameText != null && EmailText != null)
                        {
                            User user = new User();

                            user.UserName = UserNameText;
                            user.Password = PasswordText;
                            user.FirstName = FirstNameText;
                            user.LastName = LastNameText;
                            user.Email = EmailText;

                            databaseContext.User.Add(user);
                            databaseContext.SaveChanges();
                            MessageBox.Show("New user saved to database!");

                            IsVisible = "Hidden";
                            //Clear();
                            return;
                        }
                    }
                });
            }
            set { Set(ref _saveCommand, value); } // TODO: Read about this custom Set 
        }

        public string FirstNameText
        {
            get { return _firstName; }
            set { Set(ref _firstName, value); }
        }

        public string LastNameText
        {
            get { return _lastName; }
            set { Set(ref _lastName, value); }
        }

        public string EmailText
        {
            get { return _email; }
            set { Set(ref _email, value); }
        }

        public string IsVisible
        {
            get { return _isVisible; }
            set { Set(ref _isVisible, value); }
        }
    }
}
