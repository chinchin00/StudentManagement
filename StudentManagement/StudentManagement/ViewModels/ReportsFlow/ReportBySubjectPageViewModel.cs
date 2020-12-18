using Prism.Navigation;
using Prism.Services;
using StudentManagement.Enums;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.ViewModels.Base;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.ViewModels.ReportsFlow
{
    public class ReportBySubjectPageViewModel : ViewModelBase
    {
        #region private properties

        private ObservableCollection<Class> _classes;
        private ObservableCollection<Subject> _subjects;
        private ObservableCollection<string> _subjectNames;
        private int _semester;
        private string _semesterName;
        private Subject _subjectSelected;
        private string _subjectNameSelected;
        private bool _isInitialized;
        private bool _isBusy;

        #endregion

        #region public properties
        public ObservableCollection<Class> Classes
        {
            get => _classes;
            set => SetProperty(ref _classes, value);
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
                    LoadListClassReport();
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
                    LoadListClassReport();
                }
            }
        }
        #endregion

        public ReportBySubjectPageViewModel(INavigationService navigationService, IPageDialogService dialogService,
            ISQLiteHelper sqLiteHelper)
            : base(navigationService, dialogService, sqLiteHelper)
        {
            PageTitle = "Theo Môn học";
            SemesterName = "Học kỳ 1";
            if (!_isInitialized)
            {
                LoadListSubjects();
                LoadListClasses();
                LoadListClassReport();
                _isInitialized = true;
            }
        }

        #region Methods
        private void LoadListSubjects()
        {
            Subjects = new ObservableCollection<Subject>(Database.GetList<Subject>(s => s.Id > 0));
            if (SubjectNames != null)
                if (SubjectNames.Count > 0)
                    SubjectNameSelected = SubjectNames[0];
        }

        private async void LoadListClasses()
        {
            Classes = new ObservableCollection<Class>(Database.GetList<Class>(c => c.Id > 0));
        }

        private async void LoadListClassReport()
        {
            try
            {
                if (_isBusy) return;
                _isBusy = true;
                //LoadingPopup.Instance.ShowLoading();

                await Task.Run(() =>
                {
                    var temp = new ObservableCollection<Class>();
                    foreach (var c in Classes)
                    {
                        c.CountStudent(Database);
                        c.GetReportBySubject(Database, _subjectSelected.Id, _semester);
                        temp.Add(c);
                    }
                    Classes = temp;
                });

                await Task.Delay(500);
                //LoadingPopup.Instance.HideLoading();
                _isBusy = false;

            }
            catch (Exception e)
            {
                //if (LoadingPopup.Instance.IsLoading)
                //    LoadingPopup.Instance.HideLoading();
                Debug.WriteLine(e.Message);
            }
        }

        public void ListClassItemTapped(Class c)
        {
            var navParam = new NavigationParameters
            {
                { ParamKey.ScoreBoardPageType.ToString(), ScoreBoardPageType.ViewScoreBoard },
                { ParamKey.ClassInfo.ToString(), c }
            };
            NavigationService.NavigateAsync("ScoreBoardPage", navParam);
        }


        #endregion
    }
}
