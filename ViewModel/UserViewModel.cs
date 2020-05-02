using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using System.Windows.Input;
using DatabaseAccess;
using System.Windows.Controls;
using MultiplexTrack.View;

namespace MultiplexTrack
{
    public class UserViewModel : ViewModelBase
    {
        private MultiplexTrackDbContext databaseContext;

        private string _userName;
        private string _password;
        private ICommand _loginCommand;
        private ICommand _registerCommand;
        private ICommand _cancelCommand;
        private ICommand _clearCommand;

        public UserViewModel()
        {
            databaseContext = new MultiplexTrackDbContext();

            LoginCommand = new RelayCommand(() => Login());
            RegisterCommand = new RelayCommand(() => Register());
            ClearCommand = new RelayCommand(() => Clear());
            CancelCommand = new RelayCommand(() => Close());
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

                    var users = databaseContext.Users;

                    foreach (Users user in users)
                    {
                        if (UserNameText == user.User)// && PasswordText == user.Password)
                        {
                            loginSuccesfull = true;
                            MessageBox.Show("Login Successfull!");
                            Clear();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Login Failed! Try again!");
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
                return new RelayCommand(() => // TODO: Read about Relay command and this way of writing it
                {

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
            //Frame.Navigate(new UserRegister(Frame));
        }

        private void Clear()
        {
            UserNameText = "";
            PasswordText = "";
        }

    }
}
