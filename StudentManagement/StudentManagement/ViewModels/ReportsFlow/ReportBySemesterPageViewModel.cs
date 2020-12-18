using Prism.Navigation;
using Prism.Services;
using StudentManagement.Enums;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace StudentManagement.ViewModels.ReportsFlow
{
    public class ReportBySemesterPageViewModel : ViewModelBase
    {
        #region private properties

        private ObservableCollection<Class> _classes;
        private int _semester;
        private string _semesterName;
        private bool _isInitialized;
        private bool _isBusy;

        #endregion

        #region public properties
        public ObservableCollection<Class> Classes
        {
            get => _classes;
            set => SetProperty(ref _classes, value);
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

        public ReportBySemesterPageViewModel(INavigationService navigationService, IPageDialogService dialogService,
            ISQLiteHelper sqLiteHelper)
            : base(navigationService, dialogService, sqLiteHelper)
        {
            PageTitle = "Theo Học kỳ";
            SemesterName = "Học kỳ 1";
        }

        public void InitData()
        {
            if (!_isInitialized)
            {
                LoadListClasses();
                LoadListClassReport();
                _isInitialized = true;
            }
        }

        #region Methods

        private void LoadListClasses()
        {
            Classes = new ObservableCollection<Class>(Database.GetList<Class>(c => c.Id > 0));
        }

        private async void LoadListClassReport()
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
                    c.GetReportBySemester(Database, _semester);
                    temp.Add(c);
                }
                Classes = temp;
            });

            await Task.Delay(500);
            //LoadingPopup.Instance.HideLoading();
            _isBusy = false;
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
