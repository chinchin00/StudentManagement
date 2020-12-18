using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Navigation;
using Prism.Services;
using StudentManagement.Enums;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.ViewModels.Base;

namespace StudentManagement.ViewModels.AddStudentsFlow
{
    public class ChooseClassPageViewModel : ViewModelBase
    {
        public ChooseClassPageViewModel(INavigationService navigationService = null, IPageDialogService dialogService = null, ISQLiteHelper sqLiteHelper = null) : 
            base(navigationService, dialogService, sqLiteHelper)
        {
            // Set values
            PageTitle = "Chọn lớp";
            LoadClass();
        }

        #region private properties
        private ObservableCollection<Class> _classes;
        private Student _student;
        #endregion

        #region public properties
        public ObservableCollection<Class> Classes
        {
            get => _classes;
            set => SetProperty(ref _classes, value);
        }
        #endregion

        private async void LoadClass()
        {
            await Task.Run(() =>
            {
                var classes = Database.GetList<Class>(c => c.Id > 0);
                foreach (var c in classes)
                {
                    c.CountStudent(Database);
                }
                Classes = new ObservableCollection<Class>(classes);
            });
        }

        #region override

        public override void OnNavigatedNewTo(INavigationParameters parameters)
        {
            if (parameters != null)
            {
                if (parameters.ContainsKey(ParamKey.StudentInfo.ToString()))
                {
                    _student = (Student)parameters[ParamKey.StudentInfo.ToString()];
                }
            }
        }

        #endregion

        #region ClassesItemTapped
        public void ClassesItemTapped(Class _class)
        {
            if (_class.IsFull)
            {
                Dialog.DisplayAlertAsync("Thông báo", "Lớp học đã đầy, vui lòng chọn lớp học khác", "OK");
                return;
            }

            var navParam = new NavigationParameters
            {
                { ParamKey.DetailClassPageType.ToString(), DetailClassPageType.ClassAcceptStudent },
                { ParamKey.ClassInfo.ToString(), _class },
                { ParamKey.StudentInfo.ToString(), _student }
            };
            NavigationService.NavigateAsync("ClassDetailPage", navParam);
        }
        #endregion
    }
}
