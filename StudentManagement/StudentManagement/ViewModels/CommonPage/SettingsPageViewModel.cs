using Prism.Commands;
using Prism.Navigation;
using StudentManagement.Helpers;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.ViewModels.Base;
using System;
using System.Windows.Input;

namespace StudentManagement.ViewModels.CommonPage
{
    public class SettingsPageViewModel : ViewModelBase
    {
        public SettingsPageViewModel(INavigationService navigationService, ISQLiteHelper sqLiteHelper)
            : base(navigationService, sqLiteHelper: sqLiteHelper)
        {
            // Set values
            PageTitle = "Cài đặt";

            // Commands
            SettingCommand = new DelegateCommand(SettingExecute);
            LogOutCommand = new DelegateCommand(LogOutExecute);
            RoleCommand = new DelegateCommand(RoleExecute);

            InitUser();
        }

        #region Properties

        private User _currentUser;
        public User CurrentUser
        {
            get => _currentUser;
            set => SetProperty(ref _currentUser, value);
        }

        private bool _isSettingVisible;
        public bool IsSettingVisible
        {
            get => _isSettingVisible;
            set => SetProperty(ref _isSettingVisible, value);
        }

        private bool _isRoleVisible;
        public bool IsRoleVisible
        {
            get => _isRoleVisible;
            set => SetProperty(ref _isRoleVisible, value);
        }

        #endregion

        #region Command

        public ICommand RoleCommand { get; set; }
        public ICommand SettingCommand { get; set; }
        public ICommand LogOutCommand { get; set; }

        #endregion

        #region InitUser

        private void InitUser()
        {
            CurrentUser = Database.GetUser();

            // Set View depend on user's role
            IsSettingVisible = (CurrentUser.Role.Equals(RoleManager.PrincipalRole) ||
                                CurrentUser.Role.Equals(RoleManager.AdminRole));
            IsRoleVisible = CurrentUser.Role.Equals(RoleManager.AdminRole);
        }

        #endregion

        #region RoleExecute

        private void RoleExecute()
        {
            NavigationService.NavigateAsync("AdminRoleInfoPage");
        }

        #endregion

        #region SettingsExecute

        private void SettingExecute()
        {
            NavigationService.NavigateAsync("ChangeRegulationsPage");
        }

        #endregion

        private void LogOutExecute()
        {
            CurrentUser = null;
            UserHelper.Instance.Logout(Database);
            NavigationService.NavigateAsync(new Uri("https://trinhnt.com/LoginPage"));
        }
    }
}
