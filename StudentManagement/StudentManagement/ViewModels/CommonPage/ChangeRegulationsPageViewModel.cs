using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.ViewModels.Base;
using System;
using System.Windows.Input;

namespace StudentManagement.ViewModels.CommonPage
{
    public class ChangeRegulationsPageViewModel : ViewModelBase
    {
        #region private variable

        private Setting _settings;

        #endregion

        #region public variable

        public Setting Settings
        {
            get => _settings;
            set => SetProperty(ref _settings, value);
        }

        // Commands
        public ICommand SaveCommand { get; }
        public ICommand ChangeClassesInfoCommand { get; }
        public ICommand ChangeSubjectsInfoCommand { get; }

        #endregion

        public ChangeRegulationsPageViewModel(INavigationService navigationService = null,
            IPageDialogService dialogService = null,
            ISQLiteHelper sqLiteHelper = null)
            : base(navigationService, dialogService, sqLiteHelper)
        {
            PageTitle = "Quy định";

            SaveCommand = new DelegateCommand(SaveExecute);
            ChangeClassesInfoCommand = new DelegateCommand(ChangeClassesInfoExecute);
            ChangeSubjectsInfoCommand = new DelegateCommand(ChangeSubjectsInfoExecute);
        }

        #region override

        public override void OnNavigatedNewTo(INavigationParameters parameters)
        {
            if (parameters != null)
            {

            }

            Settings = Database.GetSetting();
        }

        #endregion

        #region Methods

        private async void SaveExecute()
        {
            Database.Update(Settings);
            await Dialog.DisplayAlertAsync("Thông báo", "Lưu thành công", "OK");

            // Go to home page
            string uri = "PrincipalRoleMainPage";
            await NavigationService.NavigateAsync(new Uri($"https://trinhnt.com/{uri}"));
        }

        private void ChangeClassesInfoExecute()
        {
            NavigationService.NavigateAsync("ChangeClassesInfoPage");
        }

        private void ChangeSubjectsInfoExecute()
        {
            NavigationService.NavigateAsync("ChangeSubjectsInfoPage");
        }

        #endregion
    }
}
