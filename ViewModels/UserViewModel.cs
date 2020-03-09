using DatabaseAccess.Repository;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using System.Windows.Input;

namespace MultiplexTrack
{
    class UserViewModel : ViewModelBase
    {
        private UnitOfWork unitOfWork;
        private RelayCommand<MainWindow> Cancel_Click { get; set; }
        public UserViewModel()
        {
            unitOfWork = new UnitOfWork();
            this.Cancel_Click = new RelayCommand<MainWindow>(this.CloseWindow);
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
