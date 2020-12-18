using Prism.Navigation;
using Prism.Services;
using StudentManagement.Interfaces;
using StudentManagement.ViewModels.Base;

namespace StudentManagement.ViewModels.MainPageTabbed
{
    public class AdminRoleMainPageViewModel : ViewModelBase
    {
        public AdminRoleMainPageViewModel(INavigationService navigationService = null, 
            IPageDialogService dialogService = null,
            ISQLiteHelper sqLiteHelper = null) 
            : base(navigationService, dialogService, sqLiteHelper)
        {
            PageTitle = "Main Page";
        }
    }
}
