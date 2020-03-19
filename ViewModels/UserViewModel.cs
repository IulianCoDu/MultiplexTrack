using DatabaseAccess.Repository;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;

namespace MultiplexTrack
{
    public class UserViewModel : ViewModelBase
    {
        private UnitOfWork unitOfWork;
        private ICommand _loginCommand;
        private ICommand _cancelCommand;

        public UserViewModel()
        {
            unitOfWork = new UnitOfWork();
            LoginCommand = new RelayCommand(() => Login());
            CancelCommand = new RelayCommand(() => Close());
        }

        public ICommand LoginCommand
        {
            get { return _loginCommand; }
            set { _loginCommand = value; }
        }

        public ICommand CancelCommand
        {
            get { return _cancelCommand; }
            set { _cancelCommand = value; }
        }

        public string UserName { get; set; }

        private void Close()
        {
            Application.Current.Shutdown();
        }
        private void Login()
        {

        }
    }
}
