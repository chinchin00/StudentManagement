using DryIoc;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Navigation;
using StudentManagement.Enums;
using StudentManagement.Helpers;
using StudentManagement.Interfaces;
using StudentManagement.Interfaces.Navigator;
using StudentManagement.Models;
using StudentManagement.Services.LocalDatabase;
using StudentManagement.Services.Navigator;
using StudentManagement.ViewModels;
using StudentManagement.ViewModels.AddStudentsFlow;
using StudentManagement.ViewModels.CommonPage;
using StudentManagement.ViewModels.MainPageTabbed;
using StudentManagement.ViewModels.ReportsFlow;
using StudentManagement.ViewModels.ViewClassesStudentsFlow;
using StudentManagement.Views;
using StudentManagement.Views.AddStudentsFlow;
using StudentManagement.Views.CommonPage;
using StudentManagement.Views.MainPageTabbed;
using StudentManagement.Views.ReportsFlow;
using StudentManagement.Views.ViewClassesStudentsFlow;
using System;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StudentManagement
{
    public partial class App : PrismApplication
    {
        #region Properties

        private ISQLiteHelper _sqLiteHelper;
        public INavService Navigator { get; internal set; }

        #endregion

        public App()
        {

        }

        public App(IPlatformInitializer initializer = null) : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitDatabase();
            InitMockData();
            InitializeComponent();

            await StartApp();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register Pages
            containerRegistry.RegisterForNavigation<NavigationPage>("NavigationPage");

            //CommonPage
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>("LoginPage");
            containerRegistry.RegisterForNavigation<SettingsPage, SettingsPageViewModel>("SettingsPage");
            containerRegistry.RegisterForNavigation<ChangeRegulationsPage, ChangeRegulationsPageViewModel>("ChangeRegulationsPage");
            containerRegistry.RegisterForNavigation<ChangeClassesInfoPage, ChangeClassesInfoPageViewModel>("ChangeClassesInfoPage");
            containerRegistry.RegisterForNavigation<ChangeSubjectsInfoPage, ChangeSubjectsInfoPageViewModel>("ChangeSubjectsInfoPage");
            containerRegistry.RegisterForNavigation<AdminRoleInfoPage, AdminRoleInfoPageViewModel>("AdminRoleInfoPage");

            //MainPagetabbed
            containerRegistry.RegisterForNavigation<PrincipalRoleMainPage, PrincipalRoleMainPageViewModel>("PrincipalRoleMainPage");
            containerRegistry.RegisterForNavigation<TeacherRoleMainPage, TeacherRoleMainPageViewModel>("TeacherRoleMainPage");
            containerRegistry.RegisterForNavigation<StudentRoleMainPage, StudentRoleMainPageViewModel>("StudentRoleMainPage");
            containerRegistry.RegisterForNavigation<AdminRoleMainPage, AdminRoleMainPageViewModel>("AdminRoleMainPage");

            //Home Flow
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>("HomePage");
            containerRegistry.RegisterForNavigation<ClassesPage, ClassesPageViewModel>("ClassesPage");
            containerRegistry.RegisterForNavigation<StudentsPage, StudentsPageViewModel>("StudentsPage");
            containerRegistry.RegisterForNavigation<ClassDetailPage, ClassDetailPageViewModel>("ClassDetailPage");
            containerRegistry.RegisterForNavigation<StudentDetailPage, StudentDetailPageViewModel>("StudentDetailPage");
            containerRegistry.RegisterForNavigation<ScoreBoardPage, ScoreBoardPageViewModel>("ScoreBoardPage");

            //Add New Student
            containerRegistry.RegisterForNavigation<AddNewStudentPage, AddNewStudentPageViewModel>("AddNewStudentPage");
            containerRegistry.RegisterForNavigation<ChooseClassPage, ChooseClassPageViewModel>("ChooseClassPage");
            containerRegistry.RegisterForNavigation<PersonalScoreListPage, PersonalScoreListPageViewModel>("PersonalScoreListPage");
            containerRegistry.RegisterForNavigation<SearchPage, SearchPageViewModel>("SearchPage");
            containerRegistry.RegisterForNavigation<InputScorePage, InputScorePageViewModel>("InputScorePage");

            //Reports Flow
            containerRegistry.RegisterForNavigation<ReportHomePage, ReportHomePageViewModel>("ReportHomePage");
            containerRegistry.RegisterForNavigation<ReportBySemesterPage, ReportBySemesterPageViewModel>("ReportBySemesterPage");
            containerRegistry.RegisterForNavigation<ReportBySubjectPage, ReportBySubjectPageViewModel>("ReportBySubjectPage");
            containerRegistry.RegisterForNavigation<StudentScorePage, StudentScorePageViewModel>("StudentScorePage");

            // Register Services
            containerRegistry.Register<ISQLiteHelper, SQLiteHelper>();
        }

        private void InitDatabase()
        {
            var connectionService = DependencyService.Get<IDatabaseConnection>();
            _sqLiteHelper = new SQLiteHelper(connectionService);
        }

        private void InitMockData()
        {
            //var setting = _sqLiteHelper.Get<Setting>("1");
            //var setting = _sqLiteHelper.GetSetting();
            var mockData = new MockData(_sqLiteHelper);
            mockData.InitMockData();
            //if (setting != null)
            //{
            //    if (!setting.IsInitData)
            //    {
            //        var mockData = new MockData(_sqLiteHelper);
            //        mockData.InitMockData();
            //    }
            //}
            //else
            //{
            //    var mockData = new MockData(_sqLiteHelper);
            //    mockData.InitMockData();
            //}
        }

        private async Task StartApp()
        {
            var user = _sqLiteHelper.GetUser();

            string uri = string.Empty;
            var navParam = new NavigationParameters();

            if (user == null)
                uri = "LoginPage";
            // If PrincipalRole
            else if (user.Role.Equals(RoleManager.AdminRole))
                uri = "AdminRoleMainPage";
            else if (user.Role.Equals(RoleManager.PrincipalRole))
                uri = "PrincipalRoleMainPage";
            // If TeacherRole
            else if (user.Role.Equals(RoleManager.TeacherRole))
            {
                uri = "TeacherRoleMainPage";
                var classInfo = _sqLiteHelper.Get<Class>(c => c.Id == user.ClassId);
                classInfo.CountStudent(_sqLiteHelper);
                navParam.Add(ParamKey.DetailClassPageType.ToString(), DetailClassPageType.ClassInfo);
                navParam.Add(ParamKey.ClassInfo.ToString(), classInfo);
            }
            // If StudentRole
            else
            {
                uri = "StudentRoleMainPage";
                navParam.Add(ParamKey.DetailStudentPageType.ToString(), DetailStudentPageType.StudentInfo);
                navParam.Add(ParamKey.StudentInfo.ToString(), _sqLiteHelper.Get<Student>(s => s.Id == user.Id));
            }

            await NavigationService.NavigateAsync(new Uri($"https://trinhnt.com/{uri}"), navParam);
        }

    }
}
