using DatabaseAccess.Repository;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using System;

namespace MultiplexTrack
{
    class UserViewModel : ViewModelBase
    {
        private UnitOfWork unitOfWork;
        private RelayCommand<Window> Cancel_Click { get; set; }

        private int cancel_Click_property;

        public int Cancel_Click_property
        {
            get { return cancel_Click_property; }
            set { cancel_Click_property = value; RaisePropertyChanged(() => Cancel_Click_property); }
        }

        public UserViewModel()
        {
            unitOfWork = new UnitOfWork();

            Cancel_Click = new RelayCommand<Window>(CloseWindow);
        }

        private void CloseWindow(Window window)
        {
            if (window != null)
            {
                window.Close();
            }
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
