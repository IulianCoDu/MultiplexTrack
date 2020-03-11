using DatabaseAccess.Repository;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using System;

namespace MultiplexTrack
{
    public class UserViewModel : ViewModelBase
    {
        private UnitOfWork unitOfWork;
        private RelayCommand<Window> _cancelCommand;


        public UserViewModel()
        {
            unitOfWork = new UnitOfWork();

            CancelCommand = new RelayCommand<Window>(CloseWindow);
        }

        public RelayCommand<Window> CancelCommand
        {
            get => _cancelCommand;
            set => Set(ref _cancelCommand,value);
        }

        private void CloseWindow(Window window)
        {
            window?.Close();
        }

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
