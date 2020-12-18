using Prism.Navigation;
using StudentManagement.ViewModels.Base;

namespace StudentManagement.ViewModels.MainPageTabbed
{
    public class StudentRoleMainPageViewModel : ViewModelBase
    {
        public StudentRoleMainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            PageTitle = "Main Page";
        }
    }
}
