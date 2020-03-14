using DatabaseAccess.Repository;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using System;
using System.Windows.Input;

namespace MultiplexTrack
{
    public class UserViewModel : ViewModelBase
    {
        public UserViewModel()
        {
            unitOfWork = new UnitOfWork();
            CancelCommand = new RelayCommand(() => CloseWindow(new Window()));
            ClearTextBoxCommand = new RelayCommand(() => ClearTextBox());
        }

        private UnitOfWork unitOfWork;

        private ICommand _cancelCommand;
        public ICommand CancelCommand
        {
            get { return _cancelCommand; }
            set { _cancelCommand = value; }
        }

        private void CloseWindow(Window window)
        {
            window?.Close();
        }

        private ICommand _clearTextBoxCommand;
        public ICommand ClearTextBoxCommand
        {
            get { return _clearTextBoxCommand; }
            set { _clearTextBoxCommand = value; }
        }

        private void ClearTextBox()
        {
            
        }
    }
}
