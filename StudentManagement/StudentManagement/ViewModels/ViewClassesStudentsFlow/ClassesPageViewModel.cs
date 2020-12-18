using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using StudentManagement.Enums;
using StudentManagement.Helpers;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentManagement.ViewModels.ViewClassesStudentsFlow
{
    public class ClassesPageViewModel : ViewModelBase
    {
        public ClassesPageViewModel(INavigationService navigationService = null, IPageDialogService dialogService = null, ISQLiteHelper sqLiteHelper = null) :
            base(navigationService, dialogService, sqLiteHelper)
        {
            SearchToolbarItemsCommand = new DelegateCommand(SearchToolbarItemsExecute);
            SearchIconCommand = new DelegateCommand(SearchIconExecute);
            FilterIconCommand = new DelegateCommand(FilterIconExecute);

            var classes = sqLiteHelper.GetList<Class>(c => c.Id > 0);
            foreach (var c in classes) c.CountStudent(sqLiteHelper);
            ListClass = Classes = new ObservableCollection<Class>(classes);

            ShowSearchBox = false;

        }

        #region property

        private ObservableCollection<Class> _classes;

        public ObservableCollection<Class> Classes
        {
            get => _classes;
            set => SetProperty(ref _classes, value);
        }

        private ObservableCollection<Class> _listClass;

        public ObservableCollection<Class> ListClass
        {
            get => _listClass;
            set => SetProperty(ref _listClass, value);
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

        private bool _showSearchBox;

        public bool ShowSearchBox
        {
            get => _showSearchBox;
            set => SetProperty(ref _showSearchBox, value);
        }

        #endregion

        #region Search Execute

        private void SearchExecute(string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                var serchResult = ListClass.Where(s =>
                    StringHelper.RemoveUnicodeCharacter(s.Name.ToLower())
                        .Contains(StringHelper.RemoveUnicodeCharacter(SearchText.ToLower())));
                Classes = new ObservableCollection<Class>(serchResult);
            }
            else
                Classes = ListClass;

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

        #region Search Command

        public ICommand SearchToolbarItemsCommand { get; set; }

        private void SearchToolbarItemsExecute()
        {
            ShowSearchBox = !ShowSearchBox;
        }
        public ICommand SearchIconCommand { get; set; }

        private async void SearchIconExecute()
        {
            ClickedSearchBackgroundColor = Color.White;

            await Task.Delay(200);

            ClickedSearchBackgroundColor = Color.FromHex("#F1EFEF");

            //var serchResult = Classes.Where(s => StringHelper.RemoveUnicodeCharacter(s.Name.ToLower()).Contains(StringHelper.RemoveUnicodeCharacter(SearchText.ToLower())));
            //Classes = new ObservableCollection<Class>(serchResult);
        }
        public ICommand FilterIconCommand { get; set; }

        private async void FilterIconExecute()
        {
            ClickedFilterBackgroundColor = Color.White;

            await Task.Delay(200);

            ClickedFilterBackgroundColor = Color.FromHex("#F1EFEF");

            await NavigationService.NavigateAsync("SearchPage");

            //var serchResult = Classes.Where(s => StringHelper.RemoveUnicodeCharacter(s.Name.ToLower()).Contains(StringHelper.RemoveUnicodeCharacter(SearchText.ToLower())));
            //Classes = new ObservableCollection<Class>(serchResult);
        }

        #endregion

        public void ClassesItemTapped(Class _class)
        {
            var navParam = new NavigationParameters
            {
                { ParamKey.DetailClassPageType.ToString(), DetailClassPageType.ClassInfo },
                { ParamKey.ClassInfo.ToString(), _class }
            };
            NavigationService.NavigateAsync("ClassDetailPage", navParam);
        }
    }

}
