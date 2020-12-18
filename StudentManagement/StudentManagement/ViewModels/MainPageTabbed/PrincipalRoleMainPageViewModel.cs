using Prism.Navigation;
using StudentManagement.ViewModels.Base;

namespace StudentManagement.ViewModels.MainPageTabbed
{
    public class PrincipalRoleMainPageViewModel : ViewModelBase
    {
        public PrincipalRoleMainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            PageTitle = "Main Page";
        }
    }
}
