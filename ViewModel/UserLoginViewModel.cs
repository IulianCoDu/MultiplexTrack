using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using System.Windows.Input;
using DatabaseAccess;
using MultiplexTrack.Helpers;
using System.Linq;

namespace MultiplexTrack
{
    public class UserLoginViewModel : ViewModelBase
    {
        private MultiplexTrackDbContext databaseContext;
        private IFrameNavigationService _navigationService;

        private string _userName;
        private string _password;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _isVisible;
        private ICommand _loginCommand;
        private ICommand _registerCommand;
        private ICommand _cancelCommand;
        private ICommand _clearCommand;

        public UserLoginViewModel(IFrameNavigationService navigationService)
        {
            databaseContext = new MultiplexTrackDbContext();
            _navigationService = navigationService;

            _isVisible = "Hidden";

            //LoginCommand = new RelayCommand(() => Login());
            //RegisterCommand = new RelayCommand(() => Register());
            ClearCommand = new RelayCommand(() => Clear());
            CancelCommand = new RelayCommand(() => Close());
        }

        // Navigate to next View

        public ICommand RegisterCommandNavigation
        {
            get
            {
                return _registerCommand
                       ?? (_registerCommand = new RelayCommand(
                           () =>
                           {
                               _navigationService.NavigateTo("UserRegisterView");
                           }));
            }
        }

        public string UserNameText
        {
            get { return _userName; }
            set { Set (ref _userName, value);}
        }
        public string PasswordText
        {
            get { return _password; }
            set { Set(ref _password, value); }
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

        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    bool loginSuccesfull = false;
                    if (UserNameText == null || PasswordText == null)
                    {
                        MessageBox.Show("The User and/or Password can't be empty");
                        return;
                    }

                    foreach (Users user in databaseContext.Users)
                    {
                        if (UserNameText == user.User && PasswordText == user.Password)// && PasswordText == user.Password)
                        {
                            loginSuccesfull = true;
                            MessageBox.Show("Login Successfull!");
                            Clear();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Login Failed!\nTry again, or register new account!");
                            Clear();
                            return;
                        }
                    }
                    
                });
            }
            set { Set(ref _loginCommand, value); } // TODO: Read about this custom Set
        }

        public ICommand RegisterCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    //TODO: Save User and Password into the database, then navigate to next View to fill up the extra info
                    if (databaseContext.Users.Any(name => name.User == UserNameText))
                    {
                        MessageBox.Show("User already exists!");
                        return;
                    }
                    else
                    {
                        IsVisible = "Visible";
                        while (FirstNameText != null && LastNameText != null && EmailText != null)
                        {
                            Users user = new Users();

                            user.User = UserNameText;
                            user.Password = PasswordText;
                            user.FirstName = FirstNameText;
                            user.LastName = LastNameText;
                            user.Email = EmailText;

                            databaseContext.Users.Add(user);
                            databaseContext.SaveChanges();
                            MessageBox.Show("New user saved to database!");

                            IsVisible = "Hidden";
                            Clear();
                            return;
                        }
                        Clear();
                    }
                });
            }
            set { Set(ref _registerCommand, value); } // TODO: Read about this custom Set 
        }

        public ICommand ClearCommand
        {
            get { return _clearCommand; }
            set { Set(ref _clearCommand, value); }
        }

        public ICommand CancelCommand
        {
            get { return _cancelCommand; }
            set { Set(ref _cancelCommand, value); }
        }
        private void Close()
        {
            Application.Current.Shutdown();
        }

        // This is not used
        private void Login()
        {
            string userName = _userName;
        }

        private void Register()
        {
            //Frame.Navigate(new UserRegisterView(Frame));
        }

        private void Clear()
        {
            if (UserNameText != null || PasswordText != null)
            {
                UserNameText = null;
                PasswordText = null;
            }

            if (FirstNameText != null || LastNameText != null || EmailText != null)
            {
                FirstNameText = null;
                LastNameText = null;
                EmailText = null;
                //IsVisible = "Visible";
            }
            
        }

    }
}
