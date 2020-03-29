using DatabaseAccess.Repository;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using DatabaseAccess.Models;

namespace MultiplexTrack
{
    public class UserViewModel : ViewModelBase
    {
        private UnitOfWork unitOfWork;
        private string _userNameText;
        private ICommand _loginCommand;
        private ICommand _cancelCommand;
        private ICommand _clearCommand;
        private string _passwordText;

        public string PasswordText
        {
            get { return _passwordText; }
            set { Set (ref _passwordText, value); }
        }


        public UserViewModel()
        {
            unitOfWork = new UnitOfWork();
            LoginCommand = new RelayCommand(() => Login());
            CancelCommand = new RelayCommand(() => Close());
        }

        public string UserNameText
        {
            get { return _userNameText; }
            set { Set (ref _userNameText, value);}
        }

        public ICommand LoginCommand
        {
            get { return _loginCommand; }
            set { Set (ref _loginCommand, value);}
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

        private void Close()
        {
            Application.Current.Shutdown();
        }
    }
}
