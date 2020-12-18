using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using StudentManagement.Enums;
using StudentManagement.Helpers;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.ViewModels.Base;
using System;
using System.Windows.Input;

namespace StudentManagement.ViewModels.ViewClassesStudentsFlow
{
    public class ClassDetailPageViewModel : ViewModelBase
    {
        public ClassDetailPageViewModel(INavigationService navigationService = null, IPageDialogService dialogService = null, ISQLiteHelper sqLiteHelper = null) :
            base(navigationService, dialogService, sqLiteHelper)
        {
            // Commands
            ViewListStudentCommand = new DelegateCommand(ViewListStudentExecute);
            ViewScoreBoardCommand = new DelegateCommand(ViewScoreBoardExecute);
            AcceptCommand = new DelegateCommand(AcceptExecute);

            user = Database.GetUser();

            if (user.Role.Equals(RoleManager.TeacherRole))
                GetClassInfo();


        }

        #region private properties

        private User user;
        private string _className;
        private int _numberOfStudent;
        private int _numberOfBoy;
        private int _numberOfGirl;
        private bool _isClassInfo;
        private bool _isClassAcceptStudent;
        private Class _class;
        private Student _student;

        #endregion

        #region public properties
        public string ClassName
        {
            get => _className;
            set => SetProperty(ref _className, value);
        }
        public int NumberOfStudent
        {
            get => _numberOfStudent;
            set => SetProperty(ref _numberOfStudent, value);
        }
        public int NumberOfBoy
        {
            get => _numberOfBoy;
            set => SetProperty(ref _numberOfBoy, value);
        }
        public int NumberOfGirl
        {
            get => _numberOfGirl;
            set => SetProperty(ref _numberOfGirl, value);
        }
        public bool IsClassInfo
        {
            get => _isClassInfo;
            set => SetProperty(ref _isClassInfo, value);
        }
        public bool IsClassAcceptStudent
        {
            get => _isClassAcceptStudent;
            set => SetProperty(ref _isClassAcceptStudent, value);
        }

        // Commands
        public ICommand ViewListStudentCommand { get; set; }
        public ICommand ViewScoreBoardCommand { get; set; }
        public ICommand AcceptCommand { get; set; }
        #endregion


        public override void OnNavigatedNewTo(INavigationParameters parameters)
        {
            base.OnNavigatedNewTo(parameters);

            if (parameters != null)
            {
                if (parameters.ContainsKey(ParamKey.DetailClassPageType.ToString()))
                {
                    SwitchPageMode((DetailClassPageType)parameters[ParamKey.DetailClassPageType.ToString()]);
                }
                if (parameters.ContainsKey(ParamKey.ClassInfo.ToString()))
                {
                    SetClassInfo((Class)parameters[ParamKey.ClassInfo.ToString()]);
                }
                if (parameters.ContainsKey(ParamKey.StudentInfo.ToString()))
                {
                    _student = (Student)parameters[ParamKey.StudentInfo.ToString()];
                }
            }
        }

        private void SetClassInfo(Class classInfo)
        {
            _class = classInfo;
            ClassName = classInfo.Name;
            NumberOfStudent = classInfo.Students;
            NumberOfBoy = classInfo.Boys;
            NumberOfGirl = classInfo.Girls;


        }


        #region Get Infor of class that user are teaching

        private void GetClassInfo()
        {
            var user = Database.GetUser();
            Class myclass = Database.Get<Class>(i => i.Id == user.ClassId);

            IsClassAcceptStudent = false;
            IsClassInfo = true;
            PageTitle = "Thông tin lớp";

            myclass.CountStudent(Database);

            SetClassInfo(myclass);
        }

        #endregion



        #region Methods

        private void ViewListStudentExecute()
        {
            var navParam = new NavigationParameters
            {
                {ParamKey.ClassInfo.ToString(), _class},
                {ParamKey.StudentInfo.ToString(), _student},
                {ParamKey.ShowOneClassOnly.ToString(), true}
            };
            NavigationService.NavigateAsync("StudentsPage", navParam);
        }

        private void ViewScoreBoardExecute()
        {
            var navParam = new NavigationParameters
            {
                //{ ParamKey.ScoreBoardPageType.ToString(), ScoreBoardPageType.ViewScoreBoard },
                { ParamKey.ClassInfo.ToString(), _class }
            };
            NavigationService.NavigateAsync("ScoreBoardPage", navParam);
        }

        private void AcceptExecute()
        {
            // Add student to class
            _student.ClassId = _class.Id;
            _student.ClassName = _class.Name;
            Database.Insert(_student);

            Dialog.DisplayAlertAsync("Thông báo", "Tiếp nhận học sinh thành công", "OK");

            // Show info student after adding
            var user = Database.GetUser();
            string uri = string.Empty;
            if (user.Role.Equals(RoleManager.AdminRole))
                uri = "AdminRoleMainPage";
            else
                uri = "PrincipalRoleMainPage";

            var navParam = new NavigationParameters
            {
                { ParamKey.StudentInfo.ToString(), _student },
                { ParamKey.DetailStudentPageType.ToString(), DetailStudentPageType.AddNewStudent }
            };

            //NavigationService.NavigateAsync(uri, navParam);
            NavigationService.NavigateAsync(new Uri($"https://trinhnt.com/{uri}"), navParam);

        }

        private void SwitchPageMode(DetailClassPageType type)
        {
            switch (type)
            {
                case DetailClassPageType.ClassInfo:
                    IsClassAcceptStudent = false;
                    IsClassInfo = true;
                    PageTitle = "Thông tin";
                    break;

                case DetailClassPageType.ClassAcceptStudent:
                    IsClassAcceptStudent = true;
                    IsClassInfo = false;
                    PageTitle = "Chọn lớp";
                    break;
            }
        }

        #endregion
    }
}
