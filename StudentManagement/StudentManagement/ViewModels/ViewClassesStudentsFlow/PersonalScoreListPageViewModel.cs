using Prism.Navigation;
using Prism.Services;
using StudentManagement.Enums;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.ViewModels.Base;
using System.Collections.ObjectModel;

namespace StudentManagement.ViewModels.ViewClassesStudentsFlow
{
    public class PersonalScoreListPageViewModel : ViewModelBase
    {
        private int _semester;
        private Student _student;
        private ObservableCollection<Subject> _subjects;
        public ObservableCollection<Subject> Subjects
        {
            get => _subjects;
            set => SetProperty(ref _subjects, value);
        }

        public PersonalScoreListPageViewModel(INavigationService navigationService, IPageDialogService dialogService,
            ISQLiteHelper sqLiteHelper)
            : base(navigationService, dialogService, sqLiteHelper)
        {
        }

        #region Override

        public override void OnNavigatedBackTo(INavigationParameters parameters)
        {
            if (parameters != null)
            {
                if (parameters.ContainsKey(ParamKey.NeedReload.ToString()))
                {
                    if ((bool)parameters[ParamKey.NeedReload.ToString()])
                        LoadPersonalScore();
                }
            }
        }

        public override void OnNavigatedNewTo(INavigationParameters parameters)
        {
            base.OnNavigatedNewTo(parameters);

            if (parameters != null)
            {
                //_semester
                if (parameters.ContainsKey(ParamKey.Semester.ToString()))
                {
                    _semester = (int)parameters[ParamKey.Semester.ToString()];
                    switch (_semester)
                    {
                        case 1: PageTitle = "Bảng điểm học kỳ 1"; break;
                        case 2: PageTitle = "Bảng điểm học kỳ 2"; break;
                        default: PageTitle = "Bảng điểm cả năm"; break;
                    }
                }
                //StudentInfo
                if (parameters.ContainsKey(ParamKey.StudentInfo.ToString()))
                {
                    _student = (Student)parameters[ParamKey.StudentInfo.ToString()];
                }
                else
                {
                    var user = Database.GetUser();
                    _student = Database.Get<Student>(s => s.Id == user.Id);
                }
            }

            LoadPersonalScore();
        }

        private void LoadPersonalScore()
        {
            var subjects = new ObservableCollection<Subject>(Database.GetList<Subject>(s => s.Id > 0));

            if (_semester == 1 || _semester == 2)
            {
                foreach (var subject in subjects)
                {
                    var score = Database.Get<Score>(s => s.SubjectId == subject.Id
                                                         && s.Semester == _semester
                                                         && s.StudentId == _student.Id);
                    if (score == null) continue;
                    subject.Semester = _semester;
                    subject.ScoreAvg = score.ScoreAverage;
                }
            }
            else
            {
                foreach (var subject in subjects)
                {
                    var score1 = Database.Get<Score>(s => s.SubjectId == subject.Id
                                                         && s.Semester == 1
                                                         && s.StudentId == _student.Id);
                    if (score1 == null) continue;
                    var score2 = Database.Get<Score>(s => s.SubjectId == subject.Id
                                                          && s.Semester == 2
                                                          && s.StudentId == _student.Id);
                    subject.Semester = 0;
                    subject.ScoreAvg = (score1.ScoreAverage + score2.ScoreAverage) / 2;
                }
            }

            Subjects = subjects;
        }

        #endregion

        #region Methods

        public void ScoreItemTapped(Subject subject)
        {
            if (_semester != 1 && _semester != 2)
                return;

            _student.GetScore(Database, subject.Id, _semester);
            var navParam = new NavigationParameters
            {
                { ParamKey.StudentInfo.ToString(), _student }
            };

            NavigationService.NavigateAsync("StudentScorePage", navParam);
        }

        #endregion
    }
}
