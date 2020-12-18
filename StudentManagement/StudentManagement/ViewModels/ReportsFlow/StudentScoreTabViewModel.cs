using Prism.Navigation;
using Prism.Services;
using StudentManagement.Enums;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.ViewModels.Base;
using System.Collections.ObjectModel;

namespace StudentManagement.ViewModels.ReportsFlow
{
    public class StudentScoreTabViewModel : ViewModelBase
    {
        public StudentScoreTabViewModel(INavigationService navigationService, IPageDialogService dialogService,
            ISQLiteHelper sqLiteHelper)
            : base(navigationService, dialogService, sqLiteHelper)
        {
            var user = Database.GetUser();
            _student = Database.Get<Student>(s => s.Id == user.Id);

            LoadPersonalScore();
        }

        private void LoadPersonalScore()
        {
            var subjects = new ObservableCollection<Subject>(Database.GetList<Subject>(s => s.Id > 0));

            // Score of Semester 1
            foreach (var subject in subjects)
            {
                var score = Database.Get<Score>(s => s.SubjectId == subject.Id
                                                     && s.Semester == 1
                                                     && s.StudentId == _student.Id);
                if (score == null) continue;
                subject.Semester = 1;
                subject.ScoreAvg = score.ScoreAverage;
            }

            SubjectsSemester1 = subjects;

            // Score of Semester 2
            subjects = new ObservableCollection<Subject>(Database.GetList<Subject>(s => s.Id > 0));
            foreach (var subject in subjects)
            {
                var score = Database.Get<Score>(s => s.SubjectId == subject.Id
                                                     && s.Semester == 2
                                                     && s.StudentId == _student.Id);
                if (score == null) continue;
                subject.Semester = 2;
                subject.ScoreAvg = score.ScoreAverage;
            }

            SubjectsSemester2 = subjects;

            // Score of total
            subjects = new ObservableCollection<Subject>(Database.GetList<Subject>(s => s.Id > 0));
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
            SubjectsTotal = subjects;

        }

        #region Propertires

        private int _semester;
        private Student _student;
        private ObservableCollection<Subject> _subjectsSemester1;
        public ObservableCollection<Subject> SubjectsSemester1
        {
            get => _subjectsSemester1;
            set => SetProperty(ref _subjectsSemester1, value);
        }

        private ObservableCollection<Subject> _subjectsSemester2;
        public ObservableCollection<Subject> SubjectsSemester2
        {
            get => _subjectsSemester2;
            set => SetProperty(ref _subjectsSemester2, value);
        }

        private ObservableCollection<Subject> _subjectsTotal;
        public ObservableCollection<Subject> SubjectsTotal
        {
            get => _subjectsTotal;
            set => SetProperty(ref _subjectsTotal, value);
        }

        #endregion

        #region Methods
        public void ScoreItemTapped(Subject subject)
        {
            if (subject.Semester != 1 && subject.Semester != 2)
                return;

            _student.GetScore(Database, subject.Id, subject.Semester);
            var navParam = new NavigationParameters
            {
                { ParamKey.StudentInfo.ToString(), _student },
                {ParamKey.IsStudent.ToString(), true }
            };
            NavigationService.NavigateAsync("StudentScorePage", navParam);
        }
        #endregion
    }
}
