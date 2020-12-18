using Prism.Navigation;
using Prism.Services;
using StudentManagement.Enums;
using StudentManagement.Helpers;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Linq;

namespace StudentManagement.ViewModels.ViewClassesStudentsFlow
{
    public class ScoreBoardPageViewModel : ViewModelBase
    {

        public ScoreBoardPageViewModel(INavigationService navigationService = null, IPageDialogService dialogService = null, ISQLiteHelper sqLiteHelper = null) : base(navigationService, dialogService, sqLiteHelper)
        {
            PageTitle = "Bảng điểm";
            SemesterName = "Học kỳ 1";

            user = Database.GetUser();
            if (user.Role.Equals(RoleManager.TeacherRole))
                GetScoreClassBoard();

        }

        #region private properties

        private ObservableCollection<Student> _students;
        private ObservableCollection<Subject> _subjects;
        private ObservableCollection<string> _subjectNames;
        private int _semester;
        private string _semesterName;
        private Subject _subjectSelected;
        private string _subjectNameSelected;
        private ScoreBoardPageType _pageType;
        private Class _class;
        private bool _isInitialized;

        private User user;

        #endregion

        #region public properties
        public ObservableCollection<Student> Students
        {
            get => _students;
            set => SetProperty(ref _students, value);
        }
        public ObservableCollection<Subject> Subjects
        {
            get => _subjects;
            set
            {
                SetProperty(ref _subjects, value);
                SubjectNames = new ObservableCollection<string>();
                foreach (var s in value)
                {
                    SubjectNames.Add(s.Name);
                }
            }
        }
        public ObservableCollection<string> SubjectNames
        {
            get => _subjectNames;
            private set => SetProperty(ref _subjectNames, value);
        }
        public string SubjectNameSelected
        {
            get => _subjectNameSelected;
            set
            {
                SetProperty(ref _subjectNameSelected, value);
                _subjectSelected = Subjects.FirstOrDefault(s => s.Name.Equals(value));
                if (_isInitialized)
                {
                    LoadListScoreBoard();
                }
            }
        }
        public string SemesterName
        {
            get => _semesterName;
            set
            {
                SetProperty(ref _semesterName, value);
                _semester = value == "Học kỳ 1" ? 1 : 2;
                if (_isInitialized)
                {
                    LoadListScoreBoard();
                }
            }
        }
        #endregion

        #region Override

        public override void OnNavigatedBackTo(INavigationParameters parameters)
        {
            if (parameters != null)
            {
                if (parameters.ContainsKey(ParamKey.NeedReload.ToString()))
                {
                    if ((bool)parameters[ParamKey.NeedReload.ToString()])
                        LoadListScoreBoard();
                }
            }
        }

        public override void OnNavigatedNewTo(INavigationParameters parameters)
        {
            base.OnNavigatedNewTo(parameters);

            if (parameters != null)
            {
                if (parameters.ContainsKey(ParamKey.ScoreBoardPageType.ToString()))
                {
                    _pageType = (ScoreBoardPageType)parameters[ParamKey.ScoreBoardPageType.ToString()];
                }
                if (parameters.ContainsKey(ParamKey.ClassInfo.ToString()))
                {
                    _class = (Class)parameters[ParamKey.ClassInfo.ToString()];
                }
            }

            if (!_isInitialized)
            {
                LoadListSubjects();
                LoadListStudents();
                LoadListScoreBoard();
            }
        }

        private void LoadListSubjects()
        {
            Subjects = new ObservableCollection<Subject>(Database.GetList<Subject>(s => s.Id > 0));
            if (SubjectNames != null)
                if (SubjectNames.Count > 0)
                    SubjectNameSelected = SubjectNames[0];
        }

        private void LoadListStudents()
        {
            Students = new ObservableCollection<Student>(Database.GetList<Student>(s => s.ClassId == _class.Id));
        }

        private void LoadListScoreBoard()
        {
            var students = new ObservableCollection<Student>();
            foreach (var student in Students)
            {
                student.GetScore(Database, _subjectSelected.Id, _semester);
                students.Add(student);
            }
            Students = students;
            _isInitialized = true;
        }

        #endregion

        #region Methods

        public void ScoreBoardItemTapped(Student student) // ko cần
        {
            //if (_pageType != ScoreBoardPageType.InputScoreBoard)
            //    return;
            var navParam = new NavigationParameters
            {
                { ParamKey.StudentInfo.ToString(), student }
            };
            //NavigationService.NavigateAsync("StudentScorePage", navParam);
        }

        #endregion

        #region Get Score Board of class that user are teaching

        private void GetScoreClassBoard()
        {
            _class = Database.Get<Class>(c => c.Id == user.ClassId);


            if (!_isInitialized)
            {
                LoadListSubjects();
                LoadListStudents();
                LoadListScoreBoard();
            }
        }

        #endregion
    }
}
