using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.ViewModels.Base;
using StudentManagement.Views.Popups;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace StudentManagement.ViewModels.CommonPage
{
    public class ChangeClassesInfoPageViewModel : ViewModelBase
    {
        private ObservableCollection<Class> _classes;
        public ObservableCollection<Class> Classes
        {
            get => _classes;
            set => SetProperty(ref _classes, value);
        }

        public ICommand AddCommand { get; set; }

        public static ChangeClassesInfoPageViewModel Instance { get; set; }

        public ChangeClassesInfoPageViewModel(INavigationService navigationService, IPageDialogService dialogService,
            ISQLiteHelper sqLiteHelper)
            : base(navigationService, dialogService, sqLiteHelper)
        {
            PageTitle = "Thay đổi thông tin lớp";
            AddCommand = new DelegateCommand(AddExecute);
            Classes = new ObservableCollection<Class>(Database.GetList<Class>(c => c.Id > 0));
            Instance = this;
        }

        public void EditExecute(Class cls)
        {
            EditClassPopup.Instance.Show(Database, cls);
        }

        public void EditSuccessfullyExecute()
        {
            Classes = new ObservableCollection<Class>(Database.GetList<Class>(c => c.Id > 0));
        }

        public async void RemoveExecute(Class cls)
        {
            bool isAccept = await Dialog.DisplayAlertAsync("Xóa lớp học", "Bạn có chắc muốn xóa lớp học này?", "Có", "Không");
            if (isAccept)
            {
                var student = Database.Get<Student>(s => s.ClassId == cls.Id);

                if (student != null)
                    await Dialog.DisplayAlertAsync("Thông báo", "lớp học này đang có học sinh học, không thể xóa", "OK");
                else
                {
                    Classes.Remove(cls);
                    Database.Delete(cls);
                    await Dialog.DisplayAlertAsync("Thông báo", "Xóa lớp học thành công", "OK");
                }
            }
        }

        public void AddExecute()
        {
            AddClassPopup.Instance.Show(Database);
        }

        public void AddSuccessfullyExecute()
        {
            Classes = new ObservableCollection<Class>(Database.GetList<Class>(c => c.Id > 0));
        }
    }
}
