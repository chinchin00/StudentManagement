using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.ViewModels.Base;
using StudentManagement.Views.Popups;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentManagement.ViewModels.AddStudentsFlow
{
    public class InputScorePageViewModel : ViewModelBase
    {
        public InputScorePageViewModel(INavigationService navigationService = null, IPageDialogService dialogService = null, ISQLiteHelper sqLiteHelper = null) :
            base(navigationService, dialogService, sqLiteHelper)
        {
            PageTitle = "Nhập bảng điểm môn";

            //Get list class name
            ClassNames = new ObservableCollection<string>();
            StudentNames = new ObservableCollection<string>();

            Students = new ObservableCollection<Student>();
            GetListPicker();

            SaveCommand = new DelegateCommand(SaveExecute);
        }

        #region Get List Picker

        private void GetListPicker()
        {
            var listClass = Database.GetList<Class>(c => c.Id > 0);

            foreach (var className in listClass)
            {
                ClassNames.Add(className.Name);
            }

            ClassNameSelected = ClassNames[0];
            SemesterName = "Học kỳ 1";

            LoadListSubjects();
        }

        #endregion

        #region private properties

        private int _semester;
        private Subject _subjectSelected;

        #endregion

        #region public properties

        //Lớp

        #region ClassNames

        private ObservableCollection<string> _classNames;
        public ObservableCollection<string> ClassNames
        {
            get => _classNames;
            private set => SetProperty(ref _classNames, value);
        }

        #endregion

        #region ClassNameSelected

        private string _classNameSelected;

        public string ClassNameSelected
        {
            get => _classNameSelected;
            set
            {
                SetProperty(ref _classNameSelected, value);

                //Load list Student name
                Students = new ObservableCollection<Student>(Database.GetList<Student>(s => s.ClassName == _classNameSelected));

                StudentNames = new ObservableCollection<string>();
                foreach (var student in Students)
                {
                    StudentNames.Add(student.FullName);
                }

            }
        }

        #endregion

        //Học sinh

        #region StudentName

        private ObservableCollection<string> _studentNames;
        public ObservableCollection<string> StudentNames
        {
            get => _studentNames;
            set
            {
                SetProperty(ref _studentNames, value);
            }
        }

        #endregion

        #region StudentNameSelected

        private string _studentNameSelected;
        public string StudentNameSelected
        {
            get => _studentNameSelected;
            set
            {
                SetProperty(ref _studentNameSelected, value);

                GetStudentInfo();
            }
        }

        #endregion

        #region GetStudentInfo

        private async void GetStudentInfo()
        {
            StudentInfo = new Student();

            if (StudentNameSelected == null) return;

            var studentInfo = Database.Get<Student>(st =>
                st.FullName == StudentNameSelected && st.ClassName == ClassNameSelected);

            studentInfo.GetScore(Database, _subjectSelected.Id, _semester);

            if (studentInfo.Score != null)
            {
                bool isAccept = await Dialog.DisplayAlertAsync("Thông báo",
                    $"Học sinh {StudentNameSelected} đã hoàn thành điểm số. Bạn có muốn chỉnh sửa điểm?", "Có",
                    "Không");

                if (isAccept)
                {
                    StudentInfo = studentInfo;

                    Score15M = StudentInfo.Score.Score15M;
                    Score45M = StudentInfo.Score.Score45M;
                    ScoreFinal = StudentInfo.Score.ScoreFinal;

                    ScoreAverage = StudentInfo.Score.ScoreAverage.ToString("0.00");

                }
                else
                {
                    await Dialog.DisplayAlertAsync("Thông báo", "Hãy chọn lại học sinh!", "OK");
                    StudentNameSelected = null;
                }
            }


        }

        #endregion

        #region StudentInfo

        private Student _studentInfo;
        public Student StudentInfo
        {
            get => _studentInfo;
            set
            {
                SetProperty(ref _studentInfo, value);

                GetAverageScore();
            }
        }

        #endregion

        #region GetAverageScore

        private float _score15M;
        public float Score15M
        {
            get => _score15M;
            set
            {
                SetProperty(ref _score15M, value);
                GetAverageScore();
            }
        }

        private float _score45M;
        public float Score45M
        {
            get => _score45M;
            set
            {
                SetProperty(ref _score45M, value);
                GetAverageScore();
            }
        }

        private float _scoreFinal;
        public float ScoreFinal
        {
            get => _scoreFinal;
            set
            {
                SetProperty(ref _scoreFinal, value);
                GetAverageScore();
            }
        }

        private string _scoreAverage = "-";
        public string ScoreAverage
        {
            get => _scoreAverage;
            set
            {
                SetProperty(ref _scoreAverage, value);
            }
        }

        private void GetAverageScore()
        {
            if (StudentInfo.Score == null)
            {
                ScoreAverage = "-";
                return;
            }

            float scoreAverage = (Score15M + Score45M * 2 + ScoreFinal * 3) / 6;
            ScoreAverage = scoreAverage.ToString("0.00");

        }

        #endregion

        #region ListStudents

        private ObservableCollection<Student> _students;
        public ObservableCollection<Student> Students
        {
            get => _students;
            set => SetProperty(ref _students, value);
        }

        #endregion

        //Môn học

        #region SubjectNames

        private ObservableCollection<string> _subjectNames;
        public ObservableCollection<string> SubjectNames
        {
            get => _subjectNames;
            private set => SetProperty(ref _subjectNames, value);
        }

        #endregion

        #region SubjectNameSelected

        private string _subjectNameSelected;
        public string SubjectNameSelected
        {
            get => _subjectNameSelected;
            set
            {
                SetProperty(ref _subjectNameSelected, value);
                _subjectSelected = Subjects.FirstOrDefault(s => s.Name.Equals(value));

                GetStudentInfo();

            }
        }

        #endregion

        #region Subjects

        private ObservableCollection<Subject> _subjects;
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

        #endregion

        #region LoadListSubjects

        private void LoadListSubjects()
        {
            Subjects = new ObservableCollection<Subject>(Database.GetList<Subject>(s => s.Id > 0));
            if (SubjectNames != null)
                if (SubjectNames.Count > 0)
                    SubjectNameSelected = SubjectNames[0];
        }

        #endregion

        //Học kì

        #region SemesterName

        private string _semesterName;
        public string SemesterName
        {
            get => _semesterName;
            set
            {
                SetProperty(ref _semesterName, value);
                _semester = value == "Học kỳ 1" ? 1 : 2;

                GetStudentInfo();
                //if (_isInitialized)
                //{
                //GetInfoScoreStudent();
                //}
            }
        }

        #endregion

        #endregion


        #region SaveCommand

        public ICommand SaveCommand { get; set; }
        private async void SaveExecute()
        {
            if (Score15M > 10 || Score15M < 0
                                 || Score45M > 10
                                 || Score45M < 0
                                 || ScoreFinal > 10
                                 || ScoreFinal < 0)
            {
                await Dialog.DisplayAlertAsync("Thông báo", "Điểm của học sinh không được nằm ngoài khoảng từ 0 đến 10", "OK");
                return;
            }

            bool isAccept = await Dialog.DisplayAlertAsync("Lưu điểm", "Bạn có muốn lưu điểm của học sinh?", "Có", "Không");
            if (isAccept)
            {
                StudentInfo.Score.Score15M = Score15M;
                StudentInfo.Score.Score45M = Score45M;
                StudentInfo.Score.ScoreFinal = ScoreFinal;
                Database.Update(StudentInfo.Score);

                LoadingPopup.Instance.ShowLoading();
                await Task.Delay(1000);
                LoadingPopup.Instance.HideLoading();
                await Dialog.DisplayAlertAsync("Thông báo", "Lưu điểm học sinh thành công", "OK");

                StudentNameSelected = null;

                Score15M = Score45M = ScoreFinal = 0;
                ScoreAverage = "-";

            }
        }

        #endregion

    }
}
