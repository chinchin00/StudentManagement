using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using StudentManagement.Enums;
using StudentManagement.Helpers;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.ViewModels.Base;
using StudentManagement.Views.Popups;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentManagement.ViewModels.CommonPage
{
    public class LoginPageViewModel : ViewModelBase
    {
        #region private properties

        private string _username;
        private string _password;

        #endregion

        #region public properties

        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }


        // Commands
        public ICommand LoginCommand { get; set; }

        #endregion

        public LoginPageViewModel(INavigationService navigationService = null, IPageDialogService dialogService = null,
            ISQLiteHelper sqLiteHelper = null) : base(navigationService, dialogService, sqLiteHelper)
        {
            LoginCommand = new DelegateCommand(LoginExecute);
        }

        #region Methods

        private async void LoginExecute()
        {
            if (!await CheckEmpryUsernameOrPassword())
                return;

            LoadingPopup.Instance.ShowLoading();

            await Task.Delay(500);

            if (!UserHelper.Instance.Login(Database, Username, Password))
            {
                LoadingPopup.Instance.HideLoading();
                await Dialog.DisplayAlertAsync("Thông báo", "Tên đăng nhập hoặc mật khẩu chưa chính xác", "OK");
                return;
            }

            await Task.Delay(500);
            LoadingPopup.Instance.HideLoading();

            ChooseHomePage();
        }

        private async void ChooseHomePage()
        {
            var user = Database.GetUser();
            string uri = string.Empty;
            var navParam = new NavigationParameters();

            // If PrincipalRole
            if (user.Role.Equals(RoleManager.AdminRole))
                uri = "AdminRoleMainPage";
            else if (user.Role.Equals(RoleManager.PrincipalRole))
                uri = "PrincipalRoleMainPage";
            // If TeacherRole
            else if (user.Role.Equals(RoleManager.TeacherRole))
            {
                uri = "TeacherRoleMainPage";
                var classInfo = Database.Get<Class>(c => c.Id == user.ClassId);
                classInfo.CountStudent(Database);
                navParam.Add(ParamKey.DetailClassPageType.ToString(), DetailClassPageType.ClassInfo);
                navParam.Add(ParamKey.ClassInfo.ToString(), classInfo);
            }
            // If StudentRole
            else
            {
                uri = "StudentRoleMainPage";
                navParam.Add(ParamKey.DetailStudentPageType.ToString(), DetailStudentPageType.StudentInfo);
                navParam.Add(ParamKey.StudentInfo.ToString(), Database.Get<Student>(s => s.Id == user.Id));
            }

            await NavigationService.NavigateAsync(new Uri($"https://trinhnt.com/{uri}"), navParam);
        }

        private async Task<bool> CheckEmpryUsernameOrPassword()
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                await Dialog.DisplayAlertAsync("Thông báo", "Bạn cần điền đầy đủ tên đăng nhập và mật khẩu", "OK");
                return false;
            }
            return true;
        }

        #endregion
    }
}
