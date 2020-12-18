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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentManagement.ViewModels.ViewClassesStudentsFlow
{
    public class StudentsPageViewModel : ViewModelBase
    {
        public StudentsPageViewModel(INavigationService navigationService = null, IPageDialogService dialogService = null, ISQLiteHelper sqLiteHelper = null) :
            base(navigationService, dialogService, sqLiteHelper)
        {
            Title = "Danh sách";

            user = Database.GetUser();

            if (user.Role.Equals(RoleManager.StudentRole))
                GetStudentsInClass();
            else if (!user.Role.Equals(RoleManager.TeacherRole))
                SetListStudentData();

            // Commands
            SearchToolbarItemsCommand = new DelegateCommand(SearchToolbarItemsExecute);
            SearchIconCommand = new DelegateCommand(SearchIconExecute);
            FilterIconCommand = new DelegateCommand(FilterIconExecute);
        }

        #region Properties

        private bool _showSearchBox;
        public bool ShowSearchBox
        {
            get => _showSearchBox;
            set => SetProperty(ref _showSearchBox, value);
        }

        private string _searchText;
        public string SearchText
        {
            get => _searchText;
            set
            {
                SetProperty(ref _searchText, value);
                SearchExecute(value);
            }
        }

        #endregion

        #region Search Execute

        private void SearchExecute(string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                var serchResult = ListStudents.Where(s =>
                    StringHelper.RemoveUnicodeCharacter(s.FullName.ToLower())
                        .Contains(StringHelper.RemoveUnicodeCharacter(text.ToLower())));
                Students = new ObservableCollection<Student>(serchResult);
            }
            else
                Students = ListStudents;

        }

        #endregion

        #region BackgroundColor

        private Color _clickedSearchBackgroundColor = Color.FromHex("#F1EFEF");

        public Color ClickedSearchBackgroundColor
        {
            get => _clickedSearchBackgroundColor;
            set => this.SetProperty(ref _clickedSearchBackgroundColor, value);
        }

        private Color _clickedFilterBackgroundColor = Color.FromHex("#F1EFEF");

        public Color ClickedFilterBackgroundColor
        {
            get => _clickedFilterBackgroundColor;
            set => this.SetProperty(ref _clickedFilterBackgroundColor, value);
        }

        #endregion

        #region Search student

        // Commands
        public ICommand SearchToolbarItemsCommand { get; set; }
        public ICommand SearchIconCommand { get; set; }
        public ICommand FilterIconCommand { get; set; }

        private void SearchToolbarItemsExecute()
        {
            ShowSearchBox = !ShowSearchBox;
        }

        private async void SearchIconExecute()
        {

            ClickedSearchBackgroundColor = Color.White;

            await Task.Delay(200);

            ClickedSearchBackgroundColor = Color.FromHex("#F1EFEF");

            //var serchResult = Students.Where(s =>
            //    StringHelper.RemoveUnicodeCharacter(s.FullName.ToLower())
            //        .Contains(StringHelper.RemoveUnicodeCharacter(SearchText.ToLower())));
            //Students = new ObservableCollection<Student>(serchResult);
        }

        private async void FilterIconExecute()
        {
            ClickedFilterBackgroundColor = Color.White;

            await Task.Delay(200);

            ClickedFilterBackgroundColor = Color.FromHex("#F1EFEF");

            await NavigationService.NavigateAsync("SearchPage");

            //var serchResult = Students.Where(s =>
            //    StringHelper.RemoveUnicodeCharacter(s.FullName.ToLower())
            //        .Contains(StringHelper.RemoveUnicodeCharacter(SearchText.ToLower())));
            //Students = new ObservableCollection<Student>(serchResult);
        }

        #endregion

        private void GetStudentsInClass()
        {
            var classStudent = Database.Get<Class>(s => s.Id == user.ClassId);
            SetClassInfo(classStudent);
            PageTitle = "Thông tin học sinh";
        }

        #region property

        private bool ShowSearchResultOnly = false;

        private User user;

        private ObservableCollection<Student> _students;

        public ObservableCollection<Student> Students
        {
            get => _students;
            set => SetProperty(ref _students, value);
        }

        private ObservableCollection<Student> _listStudents;

        public ObservableCollection<Student> ListStudents
        {
            get => _listStudents;
            set => SetProperty(ref _listStudents, value);
        }

        private Class _class;


        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private bool _showOneClassOnly = false;
        public bool ShowOneClassOnly
        {
            get => _showOneClassOnly;
            set => SetProperty(ref _showOneClassOnly, value);
        }

        #endregion

        #region override

        public override async void OnNavigatedNewTo(INavigationParameters parameters)
        {
            base.OnNavigatedNewTo(parameters);

            if (parameters != null)
            {
                if (parameters.ContainsKey(ParamKey.ClassInfo.ToString()))
                {
                    ShowOneClassOnly = (bool)parameters[ParamKey.ShowOneClassOnly.ToString()];
                    SetClassInfo((Class)parameters[ParamKey.ClassInfo.ToString()]);
                    return;
                }

                if (parameters.ContainsKey(ParamKey.SearchResult.ToString()) &&
                    parameters.ContainsKey(ParamKey.ExpectedResult.ToString()))
                {
                    ShowSearchResultOnly = true;

                    var result = parameters[ParamKey.ExpectedResult.ToString()] as Student;

                    float avgscore = new float();
                    if (parameters.ContainsKey(ParamKey.AvgScore.ToString()))
                    {
                        avgscore = (float)parameters[ParamKey.AvgScore.ToString()];
                    }


                    var semeter = parameters[ParamKey.Semester.ToString()].ToString();

                    await ShowResult(result, avgscore, semeter);

                    return;
                }
            }

            SetListStudentData();
            Title = "Học sinh";
        }

        private void SetClassInfo(Class classInfo)
        {
            _class = classInfo;
            Title = "Danh sách lớp " + _class.Name;
            ListStudents = Students =
                new ObservableCollection<Student>(Database.GetList<Student>(s => s.ClassId == _class.Id));
        }



        private async void SetListStudentData()
        {
            //LoadingPopup.Instance.ShowLoading();
            await Task.Run(() =>
            {
                var students = Database.GetList<Student>(s => s.Id > 0);
                foreach (var student in students)
                {
                    student.GetAvgScore(Database);
                }

                if (!ShowOneClassOnly && !ShowSearchResultOnly)
                    ListStudents = Students = new ObservableCollection<Student>(students);

            });
            //LoadingPopup.Instance.HideLoading();
        }

        #endregion

        #region Show Search Result



        private async Task ShowResult(Student result, float avgscore, string semeter)
        {
            LoadingPopup.Instance.ShowLoading();

            ObservableCollection<Student> ListResult = new ObservableCollection<Student>(Database.GetList<Student>(i => i.Id >= 0));

            if (!string.IsNullOrEmpty(result.FullName))
            {
                var searchResult = ListResult.Where(s => StringHelper.RemoveUnicodeCharacter(s.FullName.ToLower())
                     .Contains(StringHelper.RemoveUnicodeCharacter(result.FullName.ToLower())));

                ListResult = new ObservableCollection<Student>(searchResult);
            }

            if ((result.Gender.Equals(1) || result.Gender.Equals(0)) && ListResult.Count != 0)
            {
                var searchResult = ListResult.Where(s => s.Gender.Equals(result.Gender));

                ListResult = new ObservableCollection<Student>(searchResult);
            }

            if (!string.IsNullOrEmpty(result.DoB.ToString()) && !result.DoBstring.Equals("01-01-2001"))
            {
                var searchResult = ListResult.Where(s => s.DoBstring.Equals(result.DoBstring));

                ListResult = new ObservableCollection<Student>(searchResult);
            }

            if (!string.IsNullOrEmpty(result.ClassName))
            {
                var searchResult = ListResult.Where(s => s.ClassName.Equals(result.ClassName));

                ListResult = new ObservableCollection<Student>(searchResult);
            }

            if (avgscore <= 10 && avgscore > 0)
            {
                foreach (var student in ListResult)
                {
                    student.GetAvgScore(Database);
                }

                List<Student> searchResult = new List<Student>();
                if (string.Equals(semeter, "Học kỳ 1"))
                {
                    searchResult = ListResult.Where(s => s.ScoreAvg1.Equals((float)Math.Round(avgscore, 1))).ToList();
                }
                else if (string.Equals(semeter, "Học kỳ 2"))
                {
                    searchResult = ListResult.Where(s => s.ScoreAvg2.Equals((float)Math.Round(avgscore, 1))).ToList();
                }
                else if (string.Equals(semeter, "Cả năm"))
                {
                    searchResult = ListResult.Where(s => ((float)Math.Round((s.ScoreAvg1 + s.ScoreAvg2) / 2, 1)).Equals((float)Math.Round(avgscore, 1))).ToList();
                }
                else
                {
                    searchResult = ListResult.Where(s => s.ScoreAvg1.Equals((float)Math.Round(avgscore, 1)) ||
                                                         s.ScoreAvg2.Equals((float)Math.Round(avgscore, 1)) ||
                                                         ((float)Math.Round((s.ScoreAvg1 + s.ScoreAvg2) / 2, 1)).Equals((float)Math.Round(avgscore, 1))).ToList();
                }

                ListResult = new ObservableCollection<Student>(searchResult);
            }

            if (ListResult.Count == 0)
            {
                await Dialog.DisplayAlertAsync("Thông báo", "Không tìm thấy học sinh nào", "Đóng");
            }

            Students = ListResult;

            LoadingPopup.Instance.HideLoading();
        }

        #endregion

        public void StudentItemTapped(Student student)
        {
            var navParam = new NavigationParameters
            {
                { ParamKey.StudentInfo.ToString(), student }
            };
            NavigationService.NavigateAsync("StudentDetailPage", navParam);
        }
    }
}
