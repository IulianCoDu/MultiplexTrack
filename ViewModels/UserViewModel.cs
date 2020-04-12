using DatabaseAccess.Repository;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using System.Windows.Input;
using System.Linq;
using DatabaseAccess;
using System.Collections.Generic;

namespace MultiplexTrack
{
    public class UserViewModel : ViewModelBase
    {
        private UnitOfWork unitOfWork;
        private string _userNameText;
        private string _passwordText;
        private ICommand _loginCommand;
        private ICommand _cancelCommand;
        private ICommand _clearCommand;

        public UserViewModel()
        {
            unitOfWork = new UnitOfWork();

            LoginCommand = new RelayCommand(() => Login());
            ClearCommand = new RelayCommand(() => Clear());
            CancelCommand = new RelayCommand(() => Close());
        }

        public string UserNameText
        {
            get { return _userNameText; }
            set { Set (ref _userNameText, value);}
        }
        public string PasswordText
        {
            get { return _passwordText; }
            set { Set(ref _passwordText, value); }
        }

        //public ICommand LoginCommand
        //{
        //    get { return _loginCommand; }
        //    set { Set (ref _loginCommand, value);}
        //}

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

                    List<Users> users = unitOfWork.GetUser.GetAll().ToList();

                    foreach (Users user in users)
                    {
                        if (UserNameText == user.User && PasswordText == user.Password)
                        {
                            loginSuccesfull = true;
                            MessageBox.Show("Login Successfull!");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Login Failed! Try again!");
                            return;
                        }
                    }
                    
                });
            }
            set { Set(ref _loginCommand, value); }
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

        private void Login()
        {
            string userName = _userNameText;
        }

        private void Clear()
        {
            UserNameText = "";
            PasswordText = "";
        }

        private void Close()
        {
            Application.Current.Shutdown();
        }
    }
}
