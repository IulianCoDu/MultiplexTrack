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
        private UnitOfWork unitOfWork;
        private ICommand _cancelCommand;
        private string _text;

        public UserViewModel()
        {
            unitOfWork = new UnitOfWork();
            //CancelCommand = new RelayCommand(() => CloseWindow(new Window()));
        }

        //public ICommand CancelCommand
        //{
        //    get { return _cancelCommand; }
        //    set { _cancelCommand = value; }
        //}

        //private void CloseWindow(Window window)
        //{
        //    window?.Close();
        //}

        public string FocusTextBox
        {
            get { return _text; }
            set {
                if (_text != null)
                {
                    _text = null;
                    RaisePropertyChanged("ClearTextBoxCommand");
                }
            }
        }


    }
}
