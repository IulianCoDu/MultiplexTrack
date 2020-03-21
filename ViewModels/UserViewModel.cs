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
        private ICommand _loginCommand;
        private ICommand _cancelCommand;

        private string _userNameText;
        public string UserNameText
        {
            get { return _userNameText; }
            set { _userNameText = value;
                RaisePropertyChanged(UserNameText);
                RaisePropertyChanged("UserNameText");

            }
        }

        public UserViewModel()
        {
            unitOfWork = new UnitOfWork();
            LoginCommand = new RelayCommand(() => Login());
            CancelCommand = new RelayCommand(() => Close());
        }

        public ICommand LoginCommand
        {
            get { return _loginCommand; }
            set { _loginCommand = value;}
        }

        public ICommand CancelCommand
        {
            get { return _cancelCommand; }
            set { _cancelCommand = value; }
        }

        private void Close()
        {
            Application.Current.Shutdown();
        }
        private void Login()
        {
            string userName = _userNameText;
        }
    }
}
