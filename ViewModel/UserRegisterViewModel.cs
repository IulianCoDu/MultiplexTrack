﻿using DatabaseAccess;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MultiplexTrack.Helpers;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace MultiplexTrack.ViewModel
{
    public class UserRegisterViewModel : ViewModelBase
    {
        private MultiplexTrackDbContext databaseContext;
        private IFrameNavigationService _navigationService;

        private string _userName;
        private string _password;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _isVisible;
        private bool _checkBox;
        private ICommand _saveCommand;

        public UserRegisterViewModel(IFrameNavigationService navigationService)
        {
            databaseContext = new MultiplexTrackDbContext();
            _navigationService = navigationService;
        }

        public string UserNameText
        {
            get { return _userName; }
            set { Set(ref _userName, value); }
        }
        public string PasswordText
        {
            get { return _password; }
            set { Set(ref _password, value); }
        }

        public string FirstNameText
        {
            get { return _firstName; }
            set { Set(ref _firstName, value); }
        }

        public string LastNameText
        {
            get { return _lastName; }
            set { Set(ref _lastName, value); }
        }

        public string EmailText
        {
            get { return _email; }
            set { Set(ref _email, value); }
        }

        public bool CheckBox
        {
            get { return _checkBox; }
            set { Set(ref _checkBox, value); }
        }

        public ICommand SaveCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (databaseContext.User.Any(userName => userName.UserName == UserNameText))
                    {
                        MessageBox.Show("User already exists!");
                        return;
                    }
                    else
                    {
                        while (FirstNameText != null && LastNameText != null && EmailText != null)
                        {
                            User user = new User();

                            user.UserName = UserNameText;
                            user.Password = PasswordText;
                            user.FirstName = FirstNameText;
                            user.LastName = LastNameText;
                            user.Email = EmailText;
                            user.Administrator = CheckBox;

                            databaseContext.User.Add(user);
                            databaseContext.SaveChanges();
                            Clear();
                            MessageBox.Show("New user saved to database!");
                             // TODO: How to refactor the use of this method in two different Pages
                            _navigationService.NavigateTo("HomeView");
                            return;
                        }
                    }
                });
            }
            set { Set(ref _saveCommand, value); } // TODO: Read about this custom Set 
        }

        public string IsVisible
        {
            get { return _isVisible; }
            set { Set(ref _isVisible, value); }
        }

        private void Clear()
        {
            if (UserNameText != null || PasswordText != null)
            {
                UserNameText = null;
                PasswordText = null;
            }

            if (FirstNameText != null || LastNameText != null || EmailText != null)
            {
                FirstNameText = null;
                LastNameText = null;
                EmailText = null;
            }

        }
    }
}
