using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using System.Windows.Input;
using DatabaseAccess;
using MultiplexTrack.Helpers;

namespace MultiplexTrack
{
    public class UserLoginViewModel : ViewModelBase
    {
        private MultiplexTrackDbContext databaseContext;
        private IFrameNavigationService _navigationService;

        private string _userName;
        private string _password;
        private ICommand _loginCommand;
        private ICommand _registerCommand;
        private ICommand _cancelCommand;
        private ICommand _clearCommand;

        public UserLoginViewModel(IFrameNavigationService navigationService)
        {
            databaseContext = new MultiplexTrackDbContext();
            _navigationService = navigationService;

            ClearCommand = new RelayCommand(() => Clear());
            CancelCommand = new RelayCommand(() => Close());
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

        public ICommand LoginCommand
        {
            get => new RelayCommand(() =>
                                {
                                    bool loginSuccesfull = false;
                                    if (UserNameText == null || PasswordText == null)
                                    {
                                        MessageBox.Show("The User and/or Password can't be empty");
                                        return;
                                    }

                                    foreach (User user in databaseContext.User)
                                    {
                                        if (UserNameText == user.UserName && PasswordText == user.Password)
                                        {
                                            LoggedInUserSesion.CurrentUser = user;
                                            loginSuccesfull = true;
                                            MessageBox.Show("Login Successfull!");
                                            Clear();
                                            _navigationService.NavigateTo("HomeView");
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
            set { Set(ref _loginCommand, value); }
        }

        public ICommand RegisterCommand
        {
            get => new RelayCommand(() =>
                                 {
                                     _navigationService.NavigateTo("UserRegisterView");
                                     Clear();
                                 });
            set { Set(ref _registerCommand, value); }
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

        private void Clear()
        {
            if (UserNameText != null || PasswordText != null)
            {
                UserNameText = null;
                PasswordText = null;
            }
        }
    }
}
