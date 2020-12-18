using Prism.Navigation;
using StudentManagement.ViewModels.Base;

namespace StudentManagement.ViewModels.MainPageTabbed
{
    public class TeacherRoleMainPageViewModel : ViewModelBase
    {
        public TeacherRoleMainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            PageTitle = "Main Page";
        }
    }
}
