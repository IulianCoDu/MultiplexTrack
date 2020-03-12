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
            //unitOfWork = new UnitOfWork();
            //CancelCommand = new RelayCommand<Window>(CloseWindow);
            CancelCommand = new RelayCommand(() => CloseWindow(new Window()));
        }

        private UnitOfWork unitOfWork;
        //private RelayCommand<Window> _cancelCommand;
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


        //public RelayCommand<Window> CancelCommand
        //{
        //    get => _cancelCommand;
        //    set => Set(ref _cancelCommand,value);
        //}



        //public ICommand Cancel_Click 
        //{
        //    get
        //    {
        //        return new RelayCommand(() =>
        //            {

        //            });
        //    } 
        //}
    }
}
